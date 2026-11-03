namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000F7")]
public class RouteEvent
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006BD")]
	public RouteEventType eventType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Range(0, 999)]
	[Token(Token = "0x40006BE")]
	public int repeatCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Range(0.01, 20)]
	[Token(Token = "0x40006BF")]
	public float repeatDelay; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Range(0, 100)]
	[Token(Token = "0x40006C0")]
	public float awakeRate; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Range(-10000, 10000)]
	[Token(Token = "0x40006C1")]
	public float value0; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Range(-10000, 10000)]
	[Token(Token = "0x40006C2")]
	public float value1; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006C3")]
	public Vector3 vectorValue; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006C4")]
	public string stringValue; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006C5")]
	public int intValue1; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40006C6")]
	public int intValue2; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006C7")]
	public int intValue3; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Range(0, 999)]
	[Token(Token = "0x40006C8")]
	public float dotime; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Range(0, 100)]
	[Token(Token = "0x40006C9")]
	public float randomFire; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Range(0, 10)]
	[Token(Token = "0x40006CA")]
	public float randomWait; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006CB")]
	public string nameValue; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40006CC")]
	public string subnameValue; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40006CD")]
	public bool flag0; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x40006CE")]
	public bool rpidf; //Field offset: 0x69

	[Address(RVA = "0x1D3F450", Offset = "0x1D3E850", Length = "0x118")]
	[Token(Token = "0x60007C9")]
	public RouteEvent(RouteEventType rt, int repeatCount = 0, float repeatDelay = 0, float awakeRate = 0, float value0 = 0, float value1 = 0, Vector3 vectorValue = null, string stringValue = null, int intValue1 = 0, int intValue2 = 0, int intValue3 = 0, float dotime = 0, float randomFire = 0, float randomWait = 0, string nameValue = null, string subnameValue = null, bool flag0 = false, bool rpflag = false) { }

	[Address(RVA = "0x1D3E5A0", Offset = "0x1D3D9A0", Length = "0x10B")]
	[Token(Token = "0x60007CC")]
	public static RouteEvent BSelector(string bltname, int rCount = 0, float rDelay = 0, float randfire = 0, float randwait = 0, string hierarchy = null, bool isSelfDir = false) { }

	[Address(RVA = "0x1D3E6B0", Offset = "0x1D3DAB0", Length = "0x10B")]
	[Token(Token = "0x60007CB")]
	public static RouteEvent Bullet(string bltname, int rCount = 0, float rDelay = 0, float randfire = 0, float randwait = 0, string hierarchy = null, bool isSelfDir = false) { }

	[Address(RVA = "0x1D3E7C0", Offset = "0x1D3DBC0", Length = "0x15C")]
	[Token(Token = "0x60007CA")]
	public RouteEvent Clone() { }

	[Address(RVA = "0x1D3E920", Offset = "0x1D3DD20", Length = "0xDD")]
	[Token(Token = "0x60007D0")]
	public static RouteEvent Delay(float tdelay, bool isAbsolute = false) { }

	[Address(RVA = "0x1D3EA00", Offset = "0x1D3DE00", Length = "0xBB")]
	[Token(Token = "0x60007D9")]
	public static RouteEvent Finish() { }

	[Address(RVA = "0x1D3EAC0", Offset = "0x1D3DEC0", Length = "0xDD")]
	[Token(Token = "0x60007D8")]
	public static RouteEvent ForwardMove(float totalTime, float waitTime = 0) { }

	[Address(RVA = "0x1D3EBA0", Offset = "0x1D3DFA0", Length = "0xCC")]
	[Token(Token = "0x60007D1")]
	public static RouteEvent Idle(float tidle) { }

	[Address(RVA = "0x1D3EC70", Offset = "0x1D3E070", Length = "0xC9")]
	[Token(Token = "0x60007CE")]
	public static RouteEvent Label(string lname) { }

	[Address(RVA = "0x1D3ED40", Offset = "0x1D3E140", Length = "0xDB")]
	[Token(Token = "0x60007CF")]
	public static RouteEvent Loop(string lname, int loopcount) { }

	[Address(RVA = "0x1D3EE20", Offset = "0x1D3E220", Length = "0xC9")]
	[Token(Token = "0x60007D4")]
	public static RouteEvent ResetFlag(InGameObjectFlag tflag) { }

	[Address(RVA = "0x1D3EEF0", Offset = "0x1D3E2F0", Length = "0x105")]
	[Token(Token = "0x60007D7")]
	public static RouteEvent Rotate(float _dotime, float _beforeTime = 0, float _AfterTime = 0, Vector3 _vectorValue = null, string _nameValue = null, bool _Absflag = false, int _easing = 0) { }

	[Address(RVA = "0x1D3F000", Offset = "0x1D3E400", Length = "0xC9")]
	[Token(Token = "0x60007D3")]
	public static RouteEvent SetFlag(InGameObjectFlag tflag) { }

	[Address(RVA = "0x1D3F0D0", Offset = "0x1D3E4D0", Length = "0xDD")]
	[Token(Token = "0x60007D5")]
	public static RouteEvent Speed(float tspeed, float ttime) { }

	[Address(RVA = "0x1D3F1B0", Offset = "0x1D3E5B0", Length = "0xC9")]
	[Token(Token = "0x60007CD")]
	public static RouteEvent SplineMove(string rname) { }

	[Address(RVA = "0x1D3F280", Offset = "0x1D3E680", Length = "0xC9")]
	[Token(Token = "0x60007D2")]
	public static RouteEvent TaskWait(TaskFlags tflag) { }

	[Address(RVA = "0x1D3F350", Offset = "0x1D3E750", Length = "0xFE")]
	[Token(Token = "0x60007D6")]
	public static RouteEvent Translate(Vector3 tmove, float ttime, float preWait = 0, float postWait = 0, string hierarchy = null, bool isRelative = false) { }

}

