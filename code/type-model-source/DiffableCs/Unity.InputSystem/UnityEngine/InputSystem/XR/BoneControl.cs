namespace UnityEngine.InputSystem.XR;

[Token(Token = "0x20000F4")]
public class BoneControl : InputControl<Bone>
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40005B8")]
	private IntegerControl <parentBoneIndex>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40005B9")]
	private Vector3Control <position>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40005BA")]
	private QuaternionControl <rotation>k__BackingField; //Field offset: 0x150

	[InputControl(offset = 0, displayName = "parentBoneIndex")]
	[Token(Token = "0x1700033E")]
	public IntegerControl parentBoneIndex
	{
		[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C85")]
		 get { } //Length: 8
		[Address(RVA = "0x29B4B40", Offset = "0x29B3F40", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C86")]
		 set { } //Length: 19
	}

	[InputControl(offset = 4, displayName = "Position")]
	[Token(Token = "0x1700033F")]
	public Vector3Control position
	{
		[Address(RVA = "0x1D5FDB0", Offset = "0x1D5F1B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C87")]
		 get { } //Length: 8
		[Address(RVA = "0x29B4B60", Offset = "0x29B3F60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C88")]
		 set { } //Length: 19
	}

	[InputControl(offset = 16, displayName = "Rotation")]
	[Token(Token = "0x17000340")]
	public QuaternionControl rotation
	{
		[Address(RVA = "0x26CB630", Offset = "0x26CAA30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C89")]
		 get { } //Length: 8
		[Address(RVA = "0x29B4B80", Offset = "0x29B3F80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000C8A")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x29B4B00", Offset = "0x29B3F00", Length = "0x39")]
	[Token(Token = "0x6000C8E")]
	public BoneControl() { }

	[Address(RVA = "0x29B4840", Offset = "0x29B3C40", Length = "0x105")]
	[Token(Token = "0x6000C8B")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C85")]
	public IntegerControl get_parentBoneIndex() { }

	[Address(RVA = "0x1D5FDB0", Offset = "0x1D5F1B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C87")]
	public Vector3Control get_position() { }

	[Address(RVA = "0x26CB630", Offset = "0x26CAA30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C89")]
	public QuaternionControl get_rotation() { }

	[Address(RVA = "0x29B4950", Offset = "0x29B3D50", Length = "0xE6")]
	[Token(Token = "0x6000C8C")]
	public virtual Bone ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x29B4B40", Offset = "0x29B3F40", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C86")]
	public void set_parentBoneIndex(IntegerControl value) { }

	[Address(RVA = "0x29B4B60", Offset = "0x29B3F60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C88")]
	public void set_position(Vector3Control value) { }

	[Address(RVA = "0x29B4B80", Offset = "0x29B3F80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000C8A")]
	public void set_rotation(QuaternionControl value) { }

	[Address(RVA = "0x29B4A40", Offset = "0x29B3E40", Length = "0xBB")]
	[Token(Token = "0x6000C8D")]
	public virtual void WriteValueIntoState(Bone value, Void* statePtr) { }

}

