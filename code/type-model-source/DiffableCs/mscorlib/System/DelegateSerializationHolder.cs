namespace System;

[Token(Token = "0x20001AC")]
internal class DelegateSerializationHolder : ISerializable, IObjectReference
{
	[Token(Token = "0x20001AD")]
	private class DelegateEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006F6")]
		private string type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006F7")]
		private string assembly; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006F8")]
		private object target; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006F9")]
		private string targetTypeAssembly; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006FA")]
		private string targetTypeName; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006FB")]
		private string methodName; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40006FC")]
		public DelegateEntry delegateEntry; //Field offset: 0x40

		[Address(RVA = "0x207CB70", Offset = "0x207BF70", Length = "0x1FF")]
		[Token(Token = "0x6000FAE")]
		public DelegateEntry(Delegate del, string targetLabel) { }

		[Address(RVA = "0x207C800", Offset = "0x207BC00", Length = "0x361")]
		[Token(Token = "0x6000FAF")]
		public Delegate DeserializeDelegate(SerializationInfo info, int index) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006F5")]
	private Delegate _delegate; //Field offset: 0x10

	[Address(RVA = "0x207CFF0", Offset = "0x207C3F0", Length = "0x23C")]
	[Token(Token = "0x6000FAA")]
	private DelegateSerializationHolder(SerializationInfo info, StreamingContext ctx) { }

	[Address(RVA = "0x207CD70", Offset = "0x207C170", Length = "0x239")]
	[Token(Token = "0x6000FAB")]
	public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

	[Address(RVA = "0x207CFB0", Offset = "0x207C3B0", Length = "0x3E")]
	[Token(Token = "0x6000FAC")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000FAD")]
	public override object GetRealObject(StreamingContext context) { }

}

