namespace UnityEngine.UIElements;

[EventCategory(EventCategory::StyleTransition (13))]
[Token(Token = "0x2000242")]
public abstract class TransitionEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008F1")]
	private readonly StylePropertyNameCollection <stylePropertyNames>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008F2")]
	private double <elapsedTime>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170002DF")]
	protected double elapsedTime
	{
		[Address(RVA = "0x1092F70", Offset = "0x1092370", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000FAD")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170002DE")]
	public override StylePropertyNameCollection stylePropertyNames
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000FAC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1092E30", Offset = "0x1092230", Length = "0x130")]
	[Token(Token = "0x6000FAE")]
	protected TransitionEventBase`1() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000FAC")]
	public override StylePropertyNameCollection get_stylePropertyNames() { }

	[Address(RVA = "0x1092BB0", Offset = "0x1091FB0", Length = "0x179")]
	[Token(Token = "0x6000FB1")]
	public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime) { }

	[Address(RVA = "0x1092D30", Offset = "0x1092130", Length = "0x82")]
	[Token(Token = "0x6000FAF")]
	protected virtual void Init() { }

	[Address(RVA = "0x1092DC0", Offset = "0x10921C0", Length = "0x6E")]
	[Token(Token = "0x6000FB0")]
	private void LocalInit() { }

	[Address(RVA = "0x1092F70", Offset = "0x1092370", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000FAD")]
	protected void set_elapsedTime(double value) { }

}

