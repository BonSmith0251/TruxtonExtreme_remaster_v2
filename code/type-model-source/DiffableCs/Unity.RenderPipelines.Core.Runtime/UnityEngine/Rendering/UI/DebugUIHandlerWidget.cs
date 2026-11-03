namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002F7")]
public class DebugUIHandlerWidget : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[Token(Token = "0x4000DAA")]
	public Color colorDefault; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[Token(Token = "0x4000DAB")]
	public Color colorSelected; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000DAC")]
	private DebugUIHandlerWidget <parentUIHandler>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000DAD")]
	private DebugUIHandlerWidget <previousUIHandler>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000DAE")]
	private DebugUIHandlerWidget <nextUIHandler>k__BackingField; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000DAF")]
	protected Widget m_Widget; //Field offset: 0x58

	[Token(Token = "0x17000273")]
	public DebugUIHandlerWidget nextUIHandler
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60014FF")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001500")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000271")]
	public DebugUIHandlerWidget parentUIHandler
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60014FB")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60014FC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000272")]
	public DebugUIHandlerWidget previousUIHandler
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60014FD")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60014FE")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x600150C")]
	public DebugUIHandlerWidget() { }

	[Address(RVA = "0x7C8D80", Offset = "0x7C8180", Length = "0x1BC")]
	[Token(Token = "0x6001504")]
	protected T CastWidget() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60014FF")]
	public DebugUIHandlerWidget get_nextUIHandler() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60014FB")]
	public DebugUIHandlerWidget get_parentUIHandler() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60014FD")]
	public DebugUIHandlerWidget get_previousUIHandler() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6001503")]
	internal Widget GetWidget() { }

	[Address(RVA = "0x2CB9350", Offset = "0x2CB8750", Length = "0x114")]
	[Token(Token = "0x600150B")]
	public override DebugUIHandlerWidget Next() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001507")]
	public override void OnAction() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001509")]
	public override void OnDecrement(bool fast) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001506")]
	public override void OnDeselection() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001501")]
	protected override void OnEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001508")]
	public override void OnIncrement(bool fast) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6001505")]
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB9470", Offset = "0x2CB8870", Length = "0x71")]
	[Token(Token = "0x600150A")]
	public override DebugUIHandlerWidget Previous() { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001500")]
	public void set_nextUIHandler(DebugUIHandlerWidget value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60014FC")]
	public void set_parentUIHandler(DebugUIHandlerWidget value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60014FE")]
	public void set_previousUIHandler(DebugUIHandlerWidget value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x6001502")]
	internal override void SetWidget(Widget widget) { }

}

