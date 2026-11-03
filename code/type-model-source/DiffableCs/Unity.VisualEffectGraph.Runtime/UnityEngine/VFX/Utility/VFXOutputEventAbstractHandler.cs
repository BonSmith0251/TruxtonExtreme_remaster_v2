namespace UnityEngine.VFX.Utility;

[ExecuteAlways]
[RequireComponent(typeof(VisualEffect))]
[Token(Token = "0x2000046")]
public abstract class VFXOutputEventAbstractHandler : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000169")]
	public bool executeInEditor; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400016A")]
	public ExposedProperty outputEvent; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400016B")]
	private VisualEffect <m_VisualEffect>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x1700001D")]
	public abstract bool canExecuteInEditor
	{
		[Token(Token = "0x6000116")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700001E")]
	protected private VisualEffect m_VisualEffect
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000118")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000117")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2F77DA0", Offset = "0x2F771A0", Length = "0xAE")]
	[Token(Token = "0x600011D")]
	protected VFXOutputEventAbstractHandler() { }

	[Token(Token = "0x6000116")]
	public abstract bool get_canExecuteInEditor() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000118")]
	protected VisualEffect get_m_VisualEffect() { }

	[Address(RVA = "0x2F779C0", Offset = "0x2F76DC0", Length = "0x137")]
	[Token(Token = "0x600011A")]
	protected override void OnDisable() { }

	[Address(RVA = "0x2F77B00", Offset = "0x2F76F00", Length = "0x162")]
	[Token(Token = "0x6000119")]
	protected override void OnEnable() { }

	[Address(RVA = "0x2F77C70", Offset = "0x2F77070", Length = "0x12F")]
	[Token(Token = "0x600011B")]
	private void OnOutputEventRecieved(VFXOutputEventArgs args) { }

	[Token(Token = "0x600011C")]
	public abstract void OnVFXOutputEvent(VFXEventAttribute eventAttribute) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000117")]
	private void set_m_VisualEffect(VisualEffect value) { }

}

