namespace UnityEngine.Rendering;

[ExecuteInEditMode]
[Token(Token = "0x2000009")]
internal class DisallowGPUDrivenRendering : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000D")]
	private bool m_AppliedRecursively; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[FormerlySerializedAs("applyToChildrenRecursively")]
	[Token(Token = "0x400000E")]
	public bool m_applyToChildrenRecursively; //Field offset: 0x21

	[Token(Token = "0x17000003")]
	public bool applyToChildrenRecursively
	{
		[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 5
		[Address(RVA = "0x2CC5360", Offset = "0x2CC4760", Length = "0x22")]
		[Token(Token = "0x600000E")]
		 set { } //Length: 34
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000014")]
	public DisallowGPUDrivenRendering() { }

	[Address(RVA = "0x2CC5100", Offset = "0x2CC4500", Length = "0x96")]
	[Token(Token = "0x6000011")]
	private static void AllowGPUDrivenRendering(Transform transform, bool allow) { }

	[Address(RVA = "0x2CC4E20", Offset = "0x2CC4220", Length = "0x2D7")]
	[Token(Token = "0x6000012")]
	private static void AllowGPUDrivenRenderingRecursively(Transform transform, bool allow) { }

	[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
	[Token(Token = "0x600000D")]
	public bool get_applyToChildrenRecursively() { }

	[Address(RVA = "0x2CC51A0", Offset = "0x2CC45A0", Length = "0xB5")]
	[Token(Token = "0x6000010")]
	private void OnDisable() { }

	[Address(RVA = "0x2CC5260", Offset = "0x2CC4660", Length = "0xBB")]
	[Token(Token = "0x600000F")]
	private void OnEnable() { }

	[Address(RVA = "0x2CC5320", Offset = "0x2CC4720", Length = "0x33")]
	[Token(Token = "0x6000013")]
	private void OnValidate() { }

	[Address(RVA = "0x2CC5360", Offset = "0x2CC4760", Length = "0x22")]
	[Token(Token = "0x600000E")]
	public void set_applyToChildrenRecursively(bool value) { }

}

