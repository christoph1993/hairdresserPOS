using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace hairdresser_POS
{
    [Table(Name = "inventory")]
    public class Inventory
    {
        [Column(IsPrimaryKey = true)]
        public string inventoryID;
        [Column]
        public string invoiceID;
        [Column]
        public decimal value;
        [Column]
        public int itemCount;
        [Column]
        public DateTime invoiceDate;
        [Column(Expression = "GETDATE()")]
        public DateTime recieveDate;
    }

    [Table(Name = "inventoryItems")]
    public class InventoryItems
    {
        [Column(IsPrimaryKey = true)]
        public string inventoryID;
        [Column(IsPrimaryKey = true)]
        public int productID;
        [Column]
        public int quantity;
    }

    [Table(Name = "appointments")]
    public class Appointments
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int appointmentID;
        [Column]
        public DateTime appointmentTime;
        [Column]
        public string appointmentName;
        [Column]
        public string appointmentNumber;
        [Column]
        public int appointmentDresser;
        [Column]
        public string appointmentCut;
    }

    [Table(Name = "hairdressers")]
    public class HairDressers
    {
        [Column(IsPrimaryKey = true)]
        public string hairdressersID;
        [Column]
        public string FirstName;
        [Column]
        public string LastName;
        [Column]
        public string Number;
    }

    [Table(Name = "hairservices")]
    public class HairServices
    {
        [Column(IsPrimaryKey = true)]
        public string serviceID;
        [Column]
        public string serviceName;
    }

    [Table(Name = "hairproducts")]
    public class HairProducts
    {
        [Column(IsPrimaryKey = true)]
        public string productID;
        [Column]
        public long Number;
        [Column]
        public string productType;
        [Column]
        public string productInfo;
        [Column]
        public int instock;
        [Column]
        public double cost;
    }

    [Table(Name = "cuts")]
    public class Cuts
    {
        [Column(IsPrimaryKey = true)]
        public string cutID;
        [Column]
        public string cutIncludes;
        [Column]
        public string hairlength;
        [Column]
        public int cutTime;
        [Column]
        public double cost;
    }

    [Table(Name = "transactions")]
    public class Transaction
    {
        [Column(IsPrimaryKey = true)]
        public string transactionID;
        [Column]
        public double value;
        [Column]
        public int items;
        [Column(IsDbGenerated = true)]
        public DateTime date;
    }

    [Table(Name = "reciept")]
    public class Reciept
    {
        [Column(IsPrimaryKey = true)]
        public string transactionID;
        [Column(IsPrimaryKey = true)]
        public int hairserviceID;
        [Column]
        public int quantity;
    }
}
