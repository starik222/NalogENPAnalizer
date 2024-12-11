using NalogENPAnalizer.DataModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NalogENPAnalizer
{
    public class EnpXmlReaderToDb
    {
        private Dictionary<string, KbkData> kbk;
        private Dictionary<string, KppData> kpp;
        private Dictionary<string, DocOsnData> osn;
        private Dictionary<string, OktmoData> oktmo;
        private Dictionary<string, PokazatelData> pokazatel;
        private List<OperationData> operations;
        public EnpXmlReaderToDb()
        {
            kbk = new Dictionary<string, KbkData>();
            kpp = new Dictionary<string, KppData>();
            osn = new Dictionary<string, DocOsnData>();
            oktmo = new Dictionary<string, OktmoData>();
            pokazatel = new Dictionary<string, PokazatelData>();
            operations = new List<OperationData>();
        }

        public void ReadXmlToDb(string filePath)
        {
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNode rootData = doc.SelectSingleNode("/Файл/Документ/СпрПринДенСрЕНП");
            decimal saldo = Convert.ToDecimal(rootData.Attributes["ОстНачПериод"].InnerText, CultureInfo.InvariantCulture.NumberFormat);
            OperationData zeroOp = new OperationData();
            KppData zeroKpp = GetKpp("000000000");
            KbkData zerokbk = GetKbk("00000000000000000000");
            DocOsnData zeroOsn = GetOsn("Остаток на начало периода");
            OktmoData zeroOktmo = GetOktmo("00000000");
            PokazatelData zeroPokazatel = GetPokazatel("Остаток на начало периода");
            zeroOp.Summa = saldo;
            zeroOp.Kpp = zeroKpp;
            zeroOp.Oktmo = zeroOktmo;
            zeroOp.DocOsn = zeroOsn;
            zeroOp.Incoming = true;
            zeroOp.Kbk = zerokbk;
            zeroOp.OperationDate = DateTime.Parse(rootData.Attributes["ДатаНачПериод"].InnerText);
            zeroOp.Pokazatel = zeroPokazatel;
            operations.Add(zeroOp);

            XmlNode postuplNode = doc.SelectSingleNode("/Файл/Документ/СпрПринДенСрЕНП/Поступления");

            foreach (XmlNode node in postuplNode.ChildNodes)
            {
                if (node.Name == "Платежи")
                {
                    var op = CreateOperationFromNode(node, true);
                    operations.Add(op);
                }
                else if (node.Name == "УчетПереплИтог")
                {
                    foreach (XmlNode perNode in node.ChildNodes)
                    {
                        var op = CreateOperationFromNode(perNode, true);
                        op.Pereplata = true;
                        operations.Add(op);
                    }
                }
            }

            XmlNode spisanieNode = doc.SelectSingleNode("/Файл/Документ/СпрПринДенСрЕНП/Списания");

            foreach (XmlNode node in spisanieNode.ChildNodes)
            {
                if (node.Name == "СписанСчОбязИтог")
                {
                    foreach (XmlNode spNode in node.ChildNodes)
                    {
                        var op = CreateOperationFromNode(spNode, false);
                        operations.Add(op);
                    }
                }
                else
                    throw new Exception("Неизвестный блок");
            }
            SaveDataToDb();
        }



        private OperationData CreateOperationFromNode(XmlNode node, bool incoming)
        {
            string naimPokaz = node.Attributes["НаимПоказ"].InnerText;
            string dtOp = "";
            string sumOp = "";
            if (incoming)
            {
                dtOp = node.Attributes["ДатаПоступл"].InnerText;
                sumOp = node.Attributes["СумПоступл"].InnerText;
            }
            else
            {
                dtOp = node.Attributes["ДатаСписан"].InnerText;
                sumOp = node.Attributes["СумСписан"].InnerText;
            }
            string tKbk = node.Attributes["КБК"].InnerText;
            string tOktmo = node.Attributes["ОКТМО"].InnerText;
            string tKpp = node.Attributes["КПП"].InnerText;
            string docOsn = node.Attributes["ДокОснов"].InnerText;

            OperationData op = new OperationData();
            op.OperationDate = DateTime.Parse(dtOp);
            op.Summa = Convert.ToDecimal(sumOp, CultureInfo.InvariantCulture.NumberFormat);
            if (!incoming)
            {
                op.Summa *= -1;
            }
            op.Incoming = incoming;
            op.Kpp = GetKpp(tKpp);
            op.Oktmo = GetOktmo(tOktmo);
            op.DocOsn = GetOsn(docOsn);
            op.Kbk = GetKbk(tKbk);
            op.Pokazatel = GetPokazatel(naimPokaz);
            return op;
        }

        private void SaveDataToDb()
        {
            Program.MainDb.Operations.RemoveRange(Program.MainDb.Operations.ToList());
            //Program.MainDb.SaveChanges();
            foreach (var item in operations)
            {
                Program.MainDb.Operations.Add(item);
            }
            Program.MainDb.SaveChanges();
        }

        private KppData GetKpp(string val)
        {
            if (kpp.ContainsKey(val))
                return kpp[val];
            else
            {
                var res =  Program.MainDb.Kpp.FirstOrDefault(a => a.Kpp == val);
                if (res == null)
                {
                    kpp[val] = new KppData() { Kpp = val };
                    Program.MainDb.Kpp.Add(kpp[val]);
                }
                else
                {
                    kpp[val] = res;
                }
                return kpp[val];
            }
        }

        private KbkData GetKbk(string val)
        {
            if (kbk.ContainsKey(val))
                return kbk[val];
            else
            {
                var res = Program.MainDb.Kbk.FirstOrDefault(a => a.KodKbk == val);
                if (res == null)
                {
                    kbk[val] = new KbkData() { KodKbk = val };
                    Program.MainDb.Kbk.Add(kbk[val]);
                }
                else
                {
                    kbk[val] = res;
                }
                return kbk[val];
            }
        }

        private DocOsnData GetOsn(string val)
        {
            if (osn.ContainsKey(val))
                return osn[val];
            else
            {
                var res = Program.MainDb.DocOsn.FirstOrDefault(a => a.Name == val);
                if (res == null)
                {
                    osn[val] = new DocOsnData() { Name = val };
                    Program.MainDb.DocOsn.Add(osn[val]);
                }
                else
                {
                    osn[val] = res;
                }
                return osn[val];
            }
        }

        private OktmoData GetOktmo(string val)
        {
            if (oktmo.ContainsKey(val))
                return oktmo[val];
            else
            {
                var res = Program.MainDb.Oktmo.FirstOrDefault(a => a.Oktmo == val);
                if (res == null)
                {
                    oktmo[val] = new OktmoData() { Oktmo = val };
                    Program.MainDb.Oktmo.Add(oktmo[val]);
                }
                else
                {
                    oktmo[val] = res;
                }
                return oktmo[val];
            }
        }

        private PokazatelData GetPokazatel(string val)
        {
            if (pokazatel.ContainsKey(val))
                return pokazatel[val];
            else
            {
                var res = Program.MainDb.Pokazatels.FirstOrDefault(a => a.Name == val);
                if (res == null)
                {
                    pokazatel[val] = new PokazatelData() { Name = val };
                    Program.MainDb.Pokazatels.Add(pokazatel[val]);
                }
                else
                {
                    pokazatel[val] = res;
                }
                return pokazatel[val];
            }
        }

    }
}
