namespace QuanLyBanHang
{
    internal class myobject
    {
        public bool? AllowAccess { get; set; }
        public bool? AllowAdd { get; set; }
        public bool? AllowDelete { get; set; }
        public bool? AllowEdit { get; set; }
        public bool? AllowExport { get; set; }
        public bool? AllowImport { get; set; }
        public bool? AllowPrint { get; set; }
        public string ObjectName { get; set; }
        public int Object_ID { get; set; }
        public int? Parent_ID { get; set; }
    }
}