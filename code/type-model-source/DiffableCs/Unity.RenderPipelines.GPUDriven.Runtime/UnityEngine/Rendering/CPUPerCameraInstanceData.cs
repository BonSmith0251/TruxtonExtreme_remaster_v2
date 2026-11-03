namespace UnityEngine.Rendering;

[Token(Token = "0x200007A")]
internal struct CPUPerCameraInstanceData : IDisposable
{
	[Token(Token = "0x200007B")]
	public struct PerCameraInstanceDataArrays : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000232")]
		internal UnsafeList<Byte> meshLods; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000233")]
		internal UnsafeList<Byte> crossFades; //Field offset: 0x18

		[Token(Token = "0x17000042")]
		public bool IsCreated
		{
			[Address(RVA = "0x2CED250", Offset = "0x2CEC650", Length = "0x41")]
			[Token(Token = "0x600024F")]
			 get { } //Length: 65
		}

		[Address(RVA = "0x2CED150", Offset = "0x2CEC550", Length = "0xFE")]
		[Token(Token = "0x6000250")]
		public PerCameraInstanceDataArrays(int initCapacity) { }

		[Address(RVA = "0x2CECFE0", Offset = "0x2CEC3E0", Length = "0x49")]
		[Token(Token = "0x6000251")]
		public override void Dispose() { }

		[Address(RVA = "0x2CED250", Offset = "0x2CEC650", Length = "0x41")]
		[Token(Token = "0x600024F")]
		public bool get_IsCreated() { }

		[Address(RVA = "0x2CED030", Offset = "0x2CEC430", Length = "0x59")]
		[Token(Token = "0x6000253")]
		internal void Grow(int previousCapacity, int newCapacity) { }

		[Address(RVA = "0x2CED090", Offset = "0x2CEC490", Length = "0x6B")]
		[Token(Token = "0x6000252")]
		internal void Remove(int index, int lastIndex) { }

		[Address(RVA = "0x2CED100", Offset = "0x2CEC500", Length = "0x46")]
		[Token(Token = "0x6000254")]
		internal void SetDefault(int index) { }

	}

	[Token(Token = "0x400022F")]
	public const byte k_InvalidByteData = 255; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000230")]
	public NativeParallelHashMap<Int32, PerCameraInstanceDataArrays> perCameraData; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000231")]
	private NativeArray<Int32> m_StructData; //Field offset: 0x10

	[Token(Token = "0x17000041")]
	public int cameraCount
	{
		[Address(RVA = "0x2CDCD60", Offset = "0x2CDC160", Length = "0x39")]
		[Token(Token = "0x6000246")]
		 get { } //Length: 57
	}

	[Token(Token = "0x17000040")]
	public int instancesCapacity
	{
		[Address(RVA = "0x2CDCDA0", Offset = "0x2CDC1A0", Length = "0x8")]
		[Token(Token = "0x6000244")]
		 get { } //Length: 8
		[Address(RVA = "0x2CDCDB0", Offset = "0x2CDC1B0", Length = "0x8")]
		[Token(Token = "0x6000245")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700003F")]
	public int instancesLength
	{
		[Address(RVA = "0xB0A860", Offset = "0xB09C60", Length = "0x7")]
		[Token(Token = "0x6000242")]
		 get { } //Length: 7
		[Address(RVA = "0x2CDCDC0", Offset = "0x2CDC1C0", Length = "0x7")]
		[Token(Token = "0x6000243")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x2CDBFA0", Offset = "0x2CDB3A0", Length = "0x1E0")]
	[Token(Token = "0x6000249")]
	public void AllocateCameras(NativeArray<EntityId> cameraIDs) { }

	[Address(RVA = "0x2CDC190", Offset = "0x2CDB590", Length = "0x1DB")]
	[Token(Token = "0x6000248")]
	public void DeallocateCameras(NativeArray<EntityId> cameraIDs) { }

	[Address(RVA = "0x2CDC370", Offset = "0x2CDB770", Length = "0x266")]
	[Token(Token = "0x600024C")]
	public override void Dispose() { }

	[Address(RVA = "0x2CDCD60", Offset = "0x2CDC160", Length = "0x39")]
	[Token(Token = "0x6000246")]
	public int get_cameraCount() { }

	[Address(RVA = "0x2CDCDA0", Offset = "0x2CDC1A0", Length = "0x8")]
	[Token(Token = "0x6000244")]
	public int get_instancesCapacity() { }

	[Address(RVA = "0xB0A860", Offset = "0xB09C60", Length = "0x7")]
	[Token(Token = "0x6000242")]
	public int get_instancesLength() { }

	[Address(RVA = "0x2CDC5E0", Offset = "0x2CDB9E0", Length = "0x23E")]
	[Token(Token = "0x600024D")]
	internal void Grow(int newCapacity) { }

	[Address(RVA = "0x2CDC820", Offset = "0x2CDBC20", Length = "0xB")]
	[Token(Token = "0x600024B")]
	public void IncreaseInstanceCount() { }

	[Address(RVA = "0x2CDC830", Offset = "0x2CDBC30", Length = "0xC0")]
	[Token(Token = "0x6000247")]
	public void Initialize(int initCapacity) { }

	[Address(RVA = "0x2CDC8F0", Offset = "0x2CDBCF0", Length = "0x253")]
	[Token(Token = "0x600024A")]
	public void Remove(int index) { }

	[Address(RVA = "0x2CDCDB0", Offset = "0x2CDC1B0", Length = "0x8")]
	[Token(Token = "0x6000245")]
	public void set_instancesCapacity(int value) { }

	[Address(RVA = "0x2CDCDC0", Offset = "0x2CDC1C0", Length = "0x7")]
	[Token(Token = "0x6000243")]
	public void set_instancesLength(int value) { }

	[Address(RVA = "0x2CDCB50", Offset = "0x2CDBF50", Length = "0x20F")]
	[Token(Token = "0x600024E")]
	public void SetDefault(int index) { }

}

