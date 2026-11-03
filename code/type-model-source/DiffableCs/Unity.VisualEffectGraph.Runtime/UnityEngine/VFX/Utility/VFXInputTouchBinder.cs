namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Input Touch Binder")]
[Token(Token = "0x2000053")]
[VFXBinder("Input/Touch")]
internal class VFXInputTouchBinder : VFXBinderBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000054")]
	private sealed class <>c
	{
		[Token(Token = "0x40001B4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001B5")]
		public static Func<TouchControl, Boolean> <>9__20_0; //Field offset: 0x8

		[Address(RVA = "0x2F7D730", Offset = "0x2F7CB30", Length = "0x67")]
		[Token(Token = "0x6000170")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000171")]
		public <>c() { }

		[Address(RVA = "0x2F7D720", Offset = "0x2F7CB20", Length = "0xE")]
		[Token(Token = "0x6000172")]
		internal bool <GetTouchCount>b__20_0(TouchControl t) { }

	}

	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_TouchEnabledParameter")]
	[SerializeField]
	[Token(Token = "0x40001AB")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Boolean"})]
	protected ExposedProperty m_TouchEnabledProperty; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40001AC")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEditor.VFX.Position", "UnityEngine.Vector3"})]
	protected ExposedProperty m_Parameter; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40001AD")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEngine.Vector3"})]
	protected ExposedProperty m_VelocityParameter; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001AE")]
	public int TouchIndex; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001AF")]
	public Camera Target; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001B0")]
	public float Distance; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40001B1")]
	public bool SetVelocity; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001B2")]
	private Vector3 m_PreviousPosition; //Field offset: 0x58
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40001B3")]
	private bool m_PreviousTouch; //Field offset: 0x64

	[Token(Token = "0x1700002C")]
	public string Parameter
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x6000166")]
		 get { } //Length: 27
		[Address(RVA = "0x2F72FE0", Offset = "0x2F723E0", Length = "0x80")]
		[Token(Token = "0x6000167")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700002B")]
	public string TouchEnabledProperty
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x6000164")]
		 get { } //Length: 27
		[Address(RVA = "0x2F72F60", Offset = "0x2F72360", Length = "0x80")]
		[Token(Token = "0x6000165")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700002D")]
	public string VelocityParameter
	{
		[Address(RVA = "0x2F75B90", Offset = "0x2F74F90", Length = "0x1B")]
		[Token(Token = "0x6000168")]
		 get { } //Length: 27
		[Address(RVA = "0x2F75BD0", Offset = "0x2F74FD0", Length = "0x80")]
		[Token(Token = "0x6000169")]
		 set { } //Length: 128
	}

	[Address(RVA = "0x2F76B20", Offset = "0x2F75F20", Length = "0x18F")]
	[Token(Token = "0x600016F")]
	public VFXInputTouchBinder() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x6000166")]
	public string get_Parameter() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x6000164")]
	public string get_TouchEnabledProperty() { }

	[Address(RVA = "0x2F75B90", Offset = "0x2F74F90", Length = "0x1B")]
	[Token(Token = "0x6000168")]
	public string get_VelocityParameter() { }

	[Address(RVA = "0x2F75CD0", Offset = "0x2F750D0", Length = "0x216")]
	[Token(Token = "0x600016C")]
	private int GetTouchCount() { }

	[Address(RVA = "0x2F75EF0", Offset = "0x2F752F0", Length = "0x1EF")]
	[Token(Token = "0x600016D")]
	private Vector2 GetTouchPosition(int touchIndex) { }

	[Address(RVA = "0x2F760E0", Offset = "0x2F754E0", Length = "0x1EC")]
	[Token(Token = "0x600016A")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F72FE0", Offset = "0x2F723E0", Length = "0x80")]
	[Token(Token = "0x6000167")]
	public void set_Parameter(string value) { }

	[Address(RVA = "0x2F72F60", Offset = "0x2F72360", Length = "0x80")]
	[Token(Token = "0x6000165")]
	public void set_TouchEnabledProperty(string value) { }

	[Address(RVA = "0x2F75BD0", Offset = "0x2F74FD0", Length = "0x80")]
	[Token(Token = "0x6000169")]
	public void set_VelocityParameter(string value) { }

	[Address(RVA = "0x2F762D0", Offset = "0x2F756D0", Length = "0xEA")]
	[Token(Token = "0x600016E")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F763C0", Offset = "0x2F757C0", Length = "0x75A")]
	[Token(Token = "0x600016B")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

