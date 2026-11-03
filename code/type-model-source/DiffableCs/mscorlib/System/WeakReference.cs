namespace System;

[ComVisible(True)]
[Token(Token = "0x20001DF")]
public class WeakReference : ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000934")]
	private bool isLongReference; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000935")]
	private GCHandle gcHandle; //Field offset: 0x18

	[Token(Token = "0x17000177")]
	public override bool IsAlive
	{
		[Address(RVA = "0x20A9D40", Offset = "0x20A9140", Length = "0x22")]
		[Token(Token = "0x60010C9")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000178")]
	public override object Target
	{
		[Address(RVA = "0x20A9D70", Offset = "0x20A9170", Length = "0x39")]
		[Token(Token = "0x60010CA")]
		 get { } //Length: 57
		[Address(RVA = "0x20A9DB0", Offset = "0x20A91B0", Length = "0x5F")]
		[Token(Token = "0x60010CB")]
		 set { } //Length: 95
	}

	[Token(Token = "0x17000179")]
	public override bool TrackResurrection
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x60010CC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60010C5")]
	protected WeakReference() { }

	[Address(RVA = "0x20A9B90", Offset = "0x20A8F90", Length = "0x37")]
	[Token(Token = "0x60010C6")]
	public WeakReference(object target) { }

	[Address(RVA = "0x20A9BD0", Offset = "0x20A8FD0", Length = "0x44")]
	[Token(Token = "0x60010C7")]
	public WeakReference(object target, bool trackResurrection) { }

	[Address(RVA = "0x20A9C20", Offset = "0x20A9020", Length = "0x113")]
	[Token(Token = "0x60010C8")]
	protected WeakReference(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20A99E0", Offset = "0x20A8DE0", Length = "0x29")]
	[Token(Token = "0x60010C4")]
	private void AllocateHandle(object target) { }

	[Address(RVA = "0x20A9A10", Offset = "0x20A8E10", Length = "0x5B")]
	[Token(Token = "0x60010CD")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x20A9D40", Offset = "0x20A9140", Length = "0x22")]
	[Token(Token = "0x60010C9")]
	public override bool get_IsAlive() { }

	[Address(RVA = "0x20A9D70", Offset = "0x20A9170", Length = "0x39")]
	[Token(Token = "0x60010CA")]
	public override object get_Target() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x60010CC")]
	public override bool get_TrackResurrection() { }

	[Address(RVA = "0x20A9A70", Offset = "0x20A8E70", Length = "0x113")]
	[Token(Token = "0x60010CE")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20A9DB0", Offset = "0x20A91B0", Length = "0x5F")]
	[Token(Token = "0x60010CB")]
	public override void set_Target(object value) { }

}

