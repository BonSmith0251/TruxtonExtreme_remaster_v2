namespace UnityEngine.Rendering;

[Token(Token = "0x20001FA")]
public abstract class VolumeParameter : ICloneable
{
	[Token(Token = "0x400097C")]
	public const string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400097D")]
	protected bool m_OverrideState; //Field offset: 0x10

	[Token(Token = "0x170001E9")]
	public override bool overrideState
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000EF3")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x6000EF4")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000EFD")]
	protected VolumeParameter() { }

	[Token(Token = "0x6000EFC")]
	public abstract object Clone() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000EF3")]
	public override bool get_overrideState() { }

	[Address(RVA = "0x9E5D80", Offset = "0x9E5180", Length = "0xD7")]
	[Token(Token = "0x6000EF6")]
	public T GetValue() { }

	[Token(Token = "0x6000EF5")]
	internal abstract void Interp(VolumeParameter from, VolumeParameter to, float t) { }

	[Address(RVA = "0x2C6A0F0", Offset = "0x2C694F0", Length = "0x12E")]
	[Token(Token = "0x6000EFA")]
	public static bool IsObjectParameter(Type type) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000EF9")]
	protected private override void OnDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000EF8")]
	protected private override void OnEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000EFB")]
	public override void Release() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x6000EF4")]
	public override void set_overrideState(bool value) { }

	[Token(Token = "0x6000EF7")]
	public abstract void SetValue(VolumeParameter parameter) { }

}

