namespace OutGame.UI;

[Token(Token = "0x2000103")]
public class ModelViewerMn01 : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400043E")]
	private Transform _mn01; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400043F")]
	private Transform[] _mn01c; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000440")]
	private Transform[] _mn01c2; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000441")]
	private float _mn01Radius; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000442")]
	private float _rot; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000443")]
	private float _rotRange; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000444")]
	private float _rotSpeed; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000445")]
	private Vector3 center; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000446")]
	private Single[] _rotX; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000447")]
	private Vector3[] _orientation; //Field offset: 0x60

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600068D")]
	public ModelViewerMn01() { }

	[Address(RVA = "0x21EB0D0", Offset = "0x21EA4D0", Length = "0x275")]
	[Token(Token = "0x600068B")]
	private void Start() { }

	[Address(RVA = "0x21EB350", Offset = "0x21EA750", Length = "0x374")]
	[Token(Token = "0x600068C")]
	private void Update() { }

}

