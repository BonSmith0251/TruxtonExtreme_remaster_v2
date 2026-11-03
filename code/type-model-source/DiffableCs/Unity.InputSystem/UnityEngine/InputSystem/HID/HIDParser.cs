namespace UnityEngine.InputSystem.HID;

[Token(Token = "0x200014B")]
internal static class HIDParser
{
	[Token(Token = "0x200014F")]
	private struct HIDItemStateGlobal
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000877")]
		public Nullable<Int32> usagePage; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000878")]
		public Nullable<Int32> logicalMinimum; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000879")]
		public Nullable<Int32> logicalMaximum; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400087A")]
		public Nullable<Int32> physicalMinimum; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400087B")]
		public Nullable<Int32> physicalMaximum; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400087C")]
		public Nullable<Int32> unitExponent; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400087D")]
		public Nullable<Int32> unit; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400087E")]
		public Nullable<Int32> reportSize; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400087F")]
		public Nullable<Int32> reportCount; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000880")]
		public Nullable<Int32> reportId; //Field offset: 0x48

		[Address(RVA = "0x29F4780", Offset = "0x29F3B80", Length = "0x9D")]
		[Token(Token = "0x6000EC4")]
		public int GetPhysicalMax() { }

		[Address(RVA = "0x29F4820", Offset = "0x29F3C20", Length = "0x9D")]
		[Token(Token = "0x6000EC3")]
		public int GetPhysicalMin() { }

		[Address(RVA = "0x29F48C0", Offset = "0x29F3CC0", Length = "0x82")]
		[Token(Token = "0x6000EC2")]
		public UsagePage GetUsagePage(int index, ref HIDItemStateLocal localItemState) { }

	}

	[Token(Token = "0x200014E")]
	private struct HIDItemStateLocal
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400086D")]
		public Nullable<Int32> usage; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400086E")]
		public Nullable<Int32> usageMinimum; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400086F")]
		public Nullable<Int32> usageMaximum; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000870")]
		public Nullable<Int32> designatorIndex; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000871")]
		public Nullable<Int32> designatorMinimum; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000872")]
		public Nullable<Int32> designatorMaximum; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000873")]
		public Nullable<Int32> stringIndex; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000874")]
		public Nullable<Int32> stringMinimum; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000875")]
		public Nullable<Int32> stringMaximum; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000876")]
		public List<Int32> usageList; //Field offset: 0x48

		[Address(RVA = "0x29F4950", Offset = "0x29F3D50", Length = "0x118")]
		[Token(Token = "0x6000EC1")]
		public int GetUsage(int index) { }

		[Address(RVA = "0x29F4A70", Offset = "0x29F3E70", Length = "0x66")]
		[Token(Token = "0x6000EBF")]
		public static void Reset(ref HIDItemStateLocal state) { }

		[Address(RVA = "0x29F4AE0", Offset = "0x29F3EE0", Length = "0x14C")]
		[Token(Token = "0x6000EC0")]
		public void SetUsage(int value) { }

	}

	[Token(Token = "0x200014D")]
	private enum HIDItemTypeAndTag : int
	{
		Input = 128,
		Output = 144,
		Feature = 176,
		Collection = 160,
		EndCollection = 192,
		UsagePage = 4,
		LogicalMinimum = 20,
		LogicalMaximum = 36,
		PhysicalMinimum = 52,
		PhysicalMaximum = 68,
		UnitExponent = 84,
		Unit = 100,
		ReportSize = 116,
		ReportID = 132,
		ReportCount = 148,
		Push = 164,
		Pop = 180,
		Usage = 8,
		UsageMinimum = 24,
		UsageMaximum = 40,
		DesignatorIndex = 56,
		DesignatorMinimum = 72,
		DesignatorMaximum = 88,
		StringIndex = 120,
		StringMinimum = 136,
		StringMaximum = 152,
		Delimiter = 168,
	}

	[Token(Token = "0x200014C")]
	private struct HIDReportData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400084E")]
		public int reportId; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400084F")]
		public HIDReportType reportType; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000850")]
		public int currentBitOffset; //Field offset: 0x8

		[Address(RVA = "0x29F5B90", Offset = "0x29F4F90", Length = "0x1AE")]
		[Token(Token = "0x6000EBE")]
		public static int FindOrAddReport(Nullable<Int32> reportId, HIDReportType reportType, List<HIDReportData> reports) { }

	}


	[Address(RVA = "0x29F4C40", Offset = "0x29F4040", Length = "0x85")]
	[Token(Token = "0x6000EBB")]
	public static bool ParseReportDescriptor(Byte[] buffer, ref HIDDeviceDescriptor deviceDescriptor) { }

	[Address(RVA = "0x29F4CD0", Offset = "0x29F40D0", Length = "0xE52")]
	[Token(Token = "0x6000EBC")]
	public static bool ParseReportDescriptor(Byte* bufferPtr, int bufferLength, ref HIDDeviceDescriptor deviceDescriptor) { }

	[Address(RVA = "0x29F5B30", Offset = "0x29F4F30", Length = "0x5F")]
	[Token(Token = "0x6000EBD")]
	private static int ReadData(int itemSize, Byte* currentPtr, Byte* endPtr) { }

}

