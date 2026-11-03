namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001D0")]
public struct InputMetrics
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A7A")]
	private int <maxNumDevices>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000A7B")]
	private int <currentNumDevices>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A7C")]
	private int <maxStateSizeInBytes>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000A7D")]
	private int <currentStateSizeInBytes>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A7E")]
	private int <currentControlCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A7F")]
	private int <currentLayoutCount>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A80")]
	private int <totalEventBytes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000A81")]
	private int <totalEventCount>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A82")]
	private int <totalUpdateCount>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A83")]
	private double <totalEventProcessingTime>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A84")]
	private double <totalEventLagTime>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x170004FB")]
	public float averageEventBytesPerFrame
	{
		[Address(RVA = "0x2A0AFD0", Offset = "0x2A0A3D0", Length = "0x15")]
		[Token(Token = "0x6001168")]
		 get { } //Length: 21
	}

	[Token(Token = "0x170004FD")]
	public double averageLagTimePerEvent
	{
		[Address(RVA = "0x2A0AFF0", Offset = "0x2A0A3F0", Length = "0x13")]
		[Token(Token = "0x600116A")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170004FC")]
	public double averageProcessingTimePerEvent
	{
		[Address(RVA = "0x2A0B010", Offset = "0x2A0A410", Length = "0x13")]
		[Token(Token = "0x6001169")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170004F4")]
	public int currentControlCount
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600115A")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600115B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004F5")]
	public int currentLayoutCount
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600115C")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600115D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004F1")]
	public int currentNumDevices
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001154")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001155")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004F3")]
	public int currentStateSizeInBytes
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001158")]
		 get { } //Length: 4
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001159")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004F0")]
	public int maxNumDevices
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001152")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6001153")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170004F2")]
	public int maxStateSizeInBytes
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001156")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001157")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004F6")]
	public int totalEventBytes
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600115E")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600115F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004F7")]
	public int totalEventCount
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001160")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001161")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004FA")]
	public double totalEventLagTime
	{
		[Address(RVA = "0x2A0B030", Offset = "0x2A0A430", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001166")]
		 get { } //Length: 6
		[Address(RVA = "0x2A0B050", Offset = "0x2A0A450", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6001167")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170004F9")]
	public double totalEventProcessingTime
	{
		[Address(RVA = "0x2A0B040", Offset = "0x2A0A440", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001164")]
		 get { } //Length: 6
		[Address(RVA = "0x2A0B060", Offset = "0x2A0A460", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6001165")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170004F8")]
	public int totalUpdateCount
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001162")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001163")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2A0AFD0", Offset = "0x2A0A3D0", Length = "0x15")]
	[Token(Token = "0x6001168")]
	public float get_averageEventBytesPerFrame() { }

	[Address(RVA = "0x2A0AFF0", Offset = "0x2A0A3F0", Length = "0x13")]
	[Token(Token = "0x600116A")]
	public double get_averageLagTimePerEvent() { }

	[Address(RVA = "0x2A0B010", Offset = "0x2A0A410", Length = "0x13")]
	[Token(Token = "0x6001169")]
	public double get_averageProcessingTimePerEvent() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600115A")]
	public int get_currentControlCount() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600115C")]
	public int get_currentLayoutCount() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001154")]
	public int get_currentNumDevices() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001158")]
	public int get_currentStateSizeInBytes() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001152")]
	public int get_maxNumDevices() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001156")]
	public int get_maxStateSizeInBytes() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600115E")]
	public int get_totalEventBytes() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001160")]
	public int get_totalEventCount() { }

	[Address(RVA = "0x2A0B030", Offset = "0x2A0A430", Length = "0x6")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001166")]
	public double get_totalEventLagTime() { }

	[Address(RVA = "0x2A0B040", Offset = "0x2A0A440", Length = "0x6")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001164")]
	public double get_totalEventProcessingTime() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001162")]
	public int get_totalUpdateCount() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600115B")]
	public void set_currentControlCount(int value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600115D")]
	public void set_currentLayoutCount(int value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001155")]
	public void set_currentNumDevices(int value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001159")]
	public void set_currentStateSizeInBytes(int value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x6001153")]
	public void set_maxNumDevices(int value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001157")]
	public void set_maxStateSizeInBytes(int value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600115F")]
	public void set_totalEventBytes(int value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001161")]
	public void set_totalEventCount(int value) { }

	[Address(RVA = "0x2A0B050", Offset = "0x2A0A450", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6001167")]
	public void set_totalEventLagTime(double value) { }

	[Address(RVA = "0x2A0B060", Offset = "0x2A0A460", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6001165")]
	public void set_totalEventProcessingTime(double value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001163")]
	public void set_totalUpdateCount(int value) { }

}

