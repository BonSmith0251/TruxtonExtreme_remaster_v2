namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x200003E")]
public struct ObjectInitializationData
{
	[Token(Token = "0x200003F")]
	public class Serializer : ISerializationAdapter<ObjectInitializationData>, ISerializationAdapter
	{
		[Token(Token = "0x2000040")]
		private struct Data
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000A1")]
			public uint id; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x40000A2")]
			public uint type; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40000A3")]
			public uint data; //Field offset: 0x8

		}


		[Token(Token = "0x17000031")]
		public override IEnumerable<ISerializationAdapter> Dependencies
		{
			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x600016B")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600016E")]
		public Serializer() { }

		[Address(RVA = "0x2E4FF10", Offset = "0x2E4F310", Length = "0x330")]
		[Token(Token = "0x600016C")]
		public override object Deserialize(Reader reader, Type t, uint offset, out uint size) { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600016B")]
		public override IEnumerable<ISerializationAdapter> get_Dependencies() { }

		[Address(RVA = "0x2E50250", Offset = "0x2E4F650", Length = "0x178")]
		[Token(Token = "0x600016D")]
		public override uint Serialize(Writer writer, object val) { }

	}

	[FieldOffset(Offset = "0x0")]
	[FormerlySerializedAs("m_id")]
	[SerializeField]
	[Token(Token = "0x400009E")]
	private string m_Id; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[FormerlySerializedAs("m_objectType")]
	[SerializeField]
	[Token(Token = "0x400009F")]
	private SerializedType m_ObjectType; //Field offset: 0x8
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_data")]
	[SerializeField]
	[Token(Token = "0x40000A0")]
	private string m_Data; //Field offset: 0x28

	[Token(Token = "0x17000030")]
	public string Data
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000167")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700002E")]
	public string Id
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000165")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700002F")]
	public SerializedType ObjectType
	{
		[Address(RVA = "0xAEF2F0", Offset = "0xAEE6F0", Length = "0x13")]
		[Token(Token = "0x6000166")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x89AB80", Offset = "0x899F80", Length = "0x150")]
	[Token(Token = "0x6000169")]
	public TObject CreateInstance(string idOverride = null) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000167")]
	public string get_Data() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000165")]
	public string get_Id() { }

	[Address(RVA = "0xAEF2F0", Offset = "0xAEE6F0", Length = "0x13")]
	[Token(Token = "0x6000166")]
	public SerializedType get_ObjectType() { }

	[Address(RVA = "0x2E45EF0", Offset = "0x2E452F0", Length = "0x220")]
	[Token(Token = "0x600016A")]
	public AsyncOperationHandle GetAsyncInitHandle(ResourceManager rm, string idOverride = null) { }

	[Address(RVA = "0x2E46120", Offset = "0x2E45520", Length = "0x7B")]
	[Token(Token = "0x6000168")]
	public virtual string ToString() { }

}

