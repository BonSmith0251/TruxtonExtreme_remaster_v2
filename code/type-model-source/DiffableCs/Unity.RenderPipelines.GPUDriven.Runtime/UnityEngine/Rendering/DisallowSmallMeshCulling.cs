namespace UnityEngine.Rendering;

[ExecuteInEditMode]
[Token(Token = "0x200000A")]
internal class DisallowSmallMeshCulling : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000F")]
	private bool m_AppliedRecursively; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000010")]
	public bool m_applyToChildrenRecursively; //Field offset: 0x21

	[Token(Token = "0x17000004")]
	public bool applyToChildrenRecursively
	{
		[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 5
		[Address(RVA = "0x2CC58B0", Offset = "0x2CC4CB0", Length = "0x22")]
		[Token(Token = "0x6000016")]
		 set { } //Length: 34
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600001C")]
	public DisallowSmallMeshCulling() { }

	[Address(RVA = "0x2CC5670", Offset = "0x2CC4A70", Length = "0x96")]
	[Token(Token = "0x6000019")]
	private static void AllowSmallMeshCulling(Transform transform, bool allow) { }

	[Address(RVA = "0x2CC5390", Offset = "0x2CC4790", Length = "0x2D7")]
	[Token(Token = "0x600001A")]
	private static void AllowSmallMeshCullingRecursively(Transform transform, bool allow) { }

	[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
	[Token(Token = "0x6000015")]
	public bool get_applyToChildrenRecursively() { }

	[Address(RVA = "0x2CC5710", Offset = "0x2CC4B10", Length = "0xB5")]
	[Token(Token = "0x6000018")]
	private void OnDisable() { }

	[Address(RVA = "0x2CC57D0", Offset = "0x2CC4BD0", Length = "0xBB")]
	[Token(Token = "0x6000017")]
	private void OnEnable() { }

	[Address(RVA = "0x2CC5890", Offset = "0x2CC4C90", Length = "0x1F")]
	[Token(Token = "0x600001B")]
	private void OnValidate() { }

	[Address(RVA = "0x2CC58B0", Offset = "0x2CC4CB0", Length = "0x22")]
	[Token(Token = "0x6000016")]
	public void set_applyToChildrenRecursively(bool value) { }

}

