namespace UnityEngine.EventSystems;

[Token(Token = "0x20000CC")]
public struct RaycastResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000374")]
	private GameObject m_GameObject; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000375")]
	public BaseRaycaster module; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000376")]
	public float distance; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000377")]
	public float index; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000378")]
	public int depth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000379")]
	public int sortingGroupID; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400037A")]
	public int sortingGroupOrder; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400037B")]
	public int sortingLayer; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400037C")]
	public int sortingOrder; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400037D")]
	public Vector3 origin; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400037E")]
	public Vector3 worldPosition; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400037F")]
	public Vector3 worldNormal; //Field offset: 0x44
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000380")]
	public Vector2 screenPosition; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000381")]
	public int displayIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000382")]
	public UIDocument document; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000383")]
	public VisualElement element; //Field offset: 0x68

	[Token(Token = "0x17000208")]
	public GameObject gameObject
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x600079B")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x600079C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000209")]
	public bool isValid
	{
		[Address(RVA = "0x346FE40", Offset = "0x346F240", Length = "0x8D")]
		[Token(Token = "0x600079D")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x346F7D0", Offset = "0x346EBD0", Length = "0x149")]
	[Token(Token = "0x600079E")]
	public void Clear() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x600079B")]
	public GameObject get_gameObject() { }

	[Address(RVA = "0x346FE40", Offset = "0x346F240", Length = "0x8D")]
	[Token(Token = "0x600079D")]
	public bool get_isValid() { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x600079C")]
	public void set_gameObject(GameObject value) { }

	[Address(RVA = "0x346F920", Offset = "0x346ED20", Length = "0x510")]
	[Token(Token = "0x600079F")]
	public virtual string ToString() { }

}

