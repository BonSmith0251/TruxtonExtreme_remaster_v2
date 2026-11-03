namespace UnityEngine.InputSystem;

[Token(Token = "0x200003E")]
public struct InputActionProperty : IEquatable<InputActionProperty>, IEquatable<InputAction>, IEquatable<InputActionReference>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000169")]
	private bool m_UseReference; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x400016A")]
	private InputAction m_Action; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400016B")]
	private InputActionReference m_Reference; //Field offset: 0x10

	[Token(Token = "0x170000D1")]
	public InputAction action
	{
		[Address(RVA = "0x28FBA00", Offset = "0x28FAE00", Length = "0x8A")]
		[Token(Token = "0x6000286")]
		 get { } //Length: 138
	}

	[Token(Token = "0x170000D2")]
	public InputActionReference reference
	{
		[Address(RVA = "0x28FBA90", Offset = "0x28FAE90", Length = "0xD")]
		[Token(Token = "0x6000287")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170000D3")]
	internal InputAction serializedAction
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6000288")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000D4")]
	internal InputActionReference serializedReference
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000289")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x28FB980", Offset = "0x28FAD80", Length = "0x31")]
	[Token(Token = "0x600028A")]
	public InputActionProperty(InputAction action) { }

	[Address(RVA = "0x28FB9C0", Offset = "0x28FADC0", Length = "0x40")]
	[Token(Token = "0x600028B")]
	public InputActionProperty(InputActionReference reference) { }

	[Address(RVA = "0x28FB6B0", Offset = "0x28FAAB0", Length = "0x9C")]
	[Token(Token = "0x600028C")]
	public override bool Equals(InputActionProperty other) { }

	[Address(RVA = "0x28FB860", Offset = "0x28FAC60", Length = "0x1C")]
	[Token(Token = "0x600028D")]
	public override bool Equals(InputAction other) { }

	[Address(RVA = "0x28FB880", Offset = "0x28FAC80", Length = "0x5D")]
	[Token(Token = "0x600028E")]
	public override bool Equals(InputActionReference other) { }

	[Address(RVA = "0x28FB750", Offset = "0x28FAB50", Length = "0x105")]
	[Token(Token = "0x600028F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x28FBA00", Offset = "0x28FAE00", Length = "0x8A")]
	[Token(Token = "0x6000286")]
	public InputAction get_action() { }

	[Address(RVA = "0x28FBA90", Offset = "0x28FAE90", Length = "0xD")]
	[Token(Token = "0x6000287")]
	public InputActionReference get_reference() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x6000288")]
	internal InputAction get_serializedAction() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000289")]
	internal InputActionReference get_serializedReference() { }

	[Address(RVA = "0x28FB8E0", Offset = "0x28FACE0", Length = "0x9A")]
	[Token(Token = "0x6000290")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x28FBAA0", Offset = "0x28FAEA0", Length = "0x8A")]
	[Token(Token = "0x6000291")]
	public static bool op_Equality(InputActionProperty left, InputActionProperty right) { }

	[Address(RVA = "0x28FBB30", Offset = "0x28FAF30", Length = "0x8A")]
	[Token(Token = "0x6000292")]
	public static bool op_Inequality(InputActionProperty left, InputActionProperty right) { }

}

