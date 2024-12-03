using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NalogENPAnalizer.DataModels
{
    public class OperationData
    {
        public int Id { get; set; }
        public bool Incoming { get; set; }
        public bool Pereplata { get; set; }
        public int PokazatelId { get; set; }
        public PokazatelData? Pokazatel { get; set; }
        public DateTime OperationDate { get; set; }
        public decimal Summa { get; set; }
        public int KbkId { get; set; }
        public KbkData? Kbk { get; set; }
        public int OktmoId { get; set; }
        public OktmoData? Oktmo { get; set; }
        public int KppId { get; set; }
        public KppData? Kpp { get; set; }
        public int DocOsnId { get; set; }
        public DocOsnData? DocOsn { get; set; }

    }
}
