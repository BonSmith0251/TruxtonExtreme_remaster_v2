namespace System.Security.Claims;

[ComVisible(True)]
[Token(Token = "0x2000340")]
public class ClaimsIdentity : IIdentity
{
	[CompilerGenerated]
	[Token(Token = "0x2000341")]
	private sealed class <get_Claims>d__51 : IEnumerable<Claim>, IEnumerable, IEnumerator<Claim>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000DC4")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000DC5")]
		private Claim <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000DC6")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000DC7")]
		public ClaimsIdentity <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000DC8")]
		private int <i>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000DC9")]
		private IEnumerator<Claim> <>7__wrap2; //Field offset: 0x38

		[Token(Token = "0x170002B6")]
		private override Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6001A5F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170002B7")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6001A61")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6001A5B")]
		public <get_Claims>d__51(int <>1__state) { }

		[Address(RVA = "0x1EF31B0", Offset = "0x1EF25B0", Length = "0x50")]
		[Token(Token = "0x6001A5E")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1EF2CF0", Offset = "0x1EF20F0", Length = "0x34B")]
		[Token(Token = "0x6001A5D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1EF3040", Offset = "0x1EF2440", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6001A62")]
		private override IEnumerator<Claim> System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6001A5F")]
		private override Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.get_Current() { }

		[Address(RVA = "0x1EF3040", Offset = "0x1EF2440", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6001A63")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6001A61")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1EF30E0", Offset = "0x1EF24E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6001A60")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1EF3120", Offset = "0x1EF2520", Length = "0x8C")]
		[DebuggerHidden]
		[Token(Token = "0x6001A5C")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DB7")]
	private Byte[] m_userSerializationData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DB8")]
	private List<Claim> m_instanceClaims; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DB9")]
	private Collection<IEnumerable`1<Claim>> m_externalClaims; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DBA")]
	private string m_nameType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DBB")]
	private string m_roleType; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DBC")]
	private string m_version; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DBD")]
	private ClaimsIdentity m_actor; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DBE")]
	private string m_authenticationType; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DBF")]
	private object m_bootstrapContext; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DC0")]
	private string m_label; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DC1")]
	private string m_serializedNameType; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DC2")]
	private string m_serializedRoleType; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DC3")]
	private string m_serializedClaims; //Field offset: 0x70

	[Token(Token = "0x170002B3")]
	public ClaimsIdentity Actor
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001A4B")]
		 get { } //Length: 5
		[Address(RVA = "0x1EDA860", Offset = "0x1ED9C60", Length = "0xB4")]
		[Token(Token = "0x6001A4C")]
		 set { } //Length: 180
	}

	[Token(Token = "0x170002B2")]
	public override string AuthenticationType
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6001A4A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B4")]
	public override IEnumerable<Claim> Claims
	{
		[Address(RVA = "0x1EDA7B0", Offset = "0x1ED9BB0", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_Claims>d__51))]
		[Token(Token = "0x6001A4D")]
		 get { } //Length: 113
	}

	[Token(Token = "0x170002B5")]
	public override string Name
	{
		[Address(RVA = "0x1EDA830", Offset = "0x1ED9C30", Length = "0x2E")]
		[Token(Token = "0x6001A4E")]
		 get { } //Length: 46
	}

	[Address(RVA = "0x1ED9F20", Offset = "0x1ED9320", Length = "0x2C")]
	[Token(Token = "0x6001A45")]
	public ClaimsIdentity() { }

	[Address(RVA = "0x1ED9EF0", Offset = "0x1ED92F0", Length = "0x2C")]
	[Token(Token = "0x6001A46")]
	public ClaimsIdentity(IEnumerable<Claim> claims) { }

	[Address(RVA = "0x1EDA780", Offset = "0x1ED9B80", Length = "0x30")]
	[Token(Token = "0x6001A47")]
	public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	[Address(RVA = "0x1EDA110", Offset = "0x1ED9510", Length = "0x661")]
	[Token(Token = "0x6001A48")]
	internal ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	[Address(RVA = "0x1ED9F50", Offset = "0x1ED9350", Length = "0x1BF")]
	[Token(Token = "0x6001A49")]
	protected ClaimsIdentity(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1ED8640", Offset = "0x1ED7A40", Length = "0x1C6")]
	[Token(Token = "0x6001A4F")]
	public override ClaimsIdentity Clone() { }

	[Address(RVA = "0x1ED8AD0", Offset = "0x1ED7ED0", Length = "0x691")]
	[Token(Token = "0x6001A5A")]
	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext) { }

	[Address(RVA = "0x1ED8810", Offset = "0x1ED7C10", Length = "0x2B3")]
	[Token(Token = "0x6001A57")]
	private void DeserializeClaims(string serializedClaims) { }

	[Address(RVA = "0x1ED9170", Offset = "0x1ED8570", Length = "0x1E8")]
	[Token(Token = "0x6001A52")]
	public override Claim FindFirst(string type) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001A4B")]
	public ClaimsIdentity get_Actor() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6001A4A")]
	public override string get_AuthenticationType() { }

	[Address(RVA = "0x1EDA7B0", Offset = "0x1ED9BB0", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_Claims>d__51))]
	[Token(Token = "0x6001A4D")]
	public override IEnumerable<Claim> get_Claims() { }

	[Address(RVA = "0x1EDA830", Offset = "0x1ED9C30", Length = "0x2E")]
	[Token(Token = "0x6001A4E")]
	public override string get_Name() { }

	[Address(RVA = "0x1ED9360", Offset = "0x1ED8760", Length = "0x487")]
	[Token(Token = "0x6001A56")]
	protected override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1ED97F0", Offset = "0x1ED8BF0", Length = "0x44")]
	[Token(Token = "0x6001A59")]
	private bool IsCircular(ClaimsIdentity subject) { }

	[Address(RVA = "0x1ED9840", Offset = "0x1ED8C40", Length = "0xDF")]
	[OnDeserialized]
	[Token(Token = "0x6001A54")]
	private void OnDeserializedMethod(StreamingContext context) { }

	[Address(RVA = "0x1ED9920", Offset = "0x1ED8D20", Length = "0xD5")]
	[OnDeserializing]
	[Token(Token = "0x6001A55")]
	private void OnDeserializingMethod(StreamingContext context) { }

	[Address(RVA = "0x1ED9A00", Offset = "0x1ED8E00", Length = "0x80")]
	[OnSerializing]
	[Token(Token = "0x6001A53")]
	private void OnSerializingMethod(StreamingContext context) { }

	[Address(RVA = "0x1ED9A80", Offset = "0x1ED8E80", Length = "0x95")]
	[Token(Token = "0x6001A51")]
	private void SafeAddClaim(Claim claim) { }

	[Address(RVA = "0x1ED9B20", Offset = "0x1ED8F20", Length = "0x21B")]
	[Token(Token = "0x6001A50")]
	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	[Address(RVA = "0x1ED9D40", Offset = "0x1ED9140", Length = "0x1AA")]
	[Token(Token = "0x6001A58")]
	private string SerializeClaims() { }

	[Address(RVA = "0x1EDA860", Offset = "0x1ED9C60", Length = "0xB4")]
	[Token(Token = "0x6001A4C")]
	public void set_Actor(ClaimsIdentity value) { }

}

