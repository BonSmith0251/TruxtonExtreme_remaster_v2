namespace UnityEngine.InputSystem;

[Token(Token = "0x200003F")]
public class InputActionReference : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400016C")]
	internal InputActionAsset m_Asset; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400016D")]
	internal string m_ActionId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400016E")]
	private InputAction m_Action; //Field offset: 0x28

	[Token(Token = "0x170000D6")]
	public InputAction action
	{
		[Address(RVA = "0x28FC770", Offset = "0x28FBB70", Length = "0x169")]
		[Token(Token = "0x6000294")]
		 get { } //Length: 361
	}

	[Token(Token = "0x170000D5")]
	public InputActionAsset asset
	{
		[Address(RVA = "0x28FC8E0", Offset = "0x28FBCE0", Length = "0x24")]
		[Token(Token = "0x6000293")]
		 get { } //Length: 36
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x60002A1")]
	public InputActionReference() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002A0")]
	private void CheckImmutableReference() { }

	[Address(RVA = "0x28FBBC0", Offset = "0x28FAFC0", Length = "0x193")]
	[Token(Token = "0x600029C")]
	public static InputActionReference Create(InputAction action) { }

	[Address(RVA = "0x28FC770", Offset = "0x28FBB70", Length = "0x169")]
	[Token(Token = "0x6000294")]
	public InputAction get_action() { }

	[Address(RVA = "0x28FC8E0", Offset = "0x28FBCE0", Length = "0x24")]
	[Token(Token = "0x6000293")]
	public InputActionAsset get_asset() { }

	[Address(RVA = "0x28FBD60", Offset = "0x28FB160", Length = "0xB1")]
	[Token(Token = "0x6000299")]
	private static string GetDisplayName(InputAction action) { }

	[Address(RVA = "0x17A8580", Offset = "0x17A7980", Length = "0x13")]
	[Token(Token = "0x600029E")]
	internal void Invalidate() { }

	[Address(RVA = "0x28FBE20", Offset = "0x28FB220", Length = "0x101")]
	[Token(Token = "0x600029D")]
	internal static void InvalidateAll() { }

	[Address(RVA = "0x28FC910", Offset = "0x28FBD10", Length = "0xF")]
	[Token(Token = "0x600029B")]
	public static InputAction op_Implicit(InputActionReference reference) { }

	[Address(RVA = "0x28FC040", Offset = "0x28FB440", Length = "0x14B")]
	[Token(Token = "0x6000295")]
	public void Set(InputAction action) { }

	[Address(RVA = "0x28FC190", Offset = "0x28FB590", Length = "0x2A9")]
	[Token(Token = "0x6000296")]
	public void Set(InputActionAsset asset, string mapName, string actionName) { }

	[Address(RVA = "0x28FBF30", Offset = "0x28FB330", Length = "0x10A")]
	[Token(Token = "0x6000297")]
	private void SetInternal(InputActionAsset assetArg, InputAction actionArg) { }

	[Address(RVA = "0x28FC440", Offset = "0x28FB840", Length = "0xD8")]
	[Token(Token = "0x600029A")]
	internal string ToDisplayName() { }

	[Address(RVA = "0x28FC520", Offset = "0x28FB920", Length = "0x7")]
	[Token(Token = "0x600029F")]
	public InputAction ToInputAction() { }

	[Address(RVA = "0x28FC530", Offset = "0x28FB930", Length = "0x234")]
	[Token(Token = "0x6000298")]
	public virtual string ToString() { }

}

