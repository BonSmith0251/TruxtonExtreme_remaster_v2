namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000F9")]
public class RouteData : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40006D2")]
	public int dataVersion; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x40006D3")]
	public float duration; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40006D4")]
	public float moveSpeed; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40006D5")]
	public Vector3 rotate; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40006D6")]
	public Ease easeType; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40006D7")]
	public PathType pathType; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40006D8")]
	public int lookAtType; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40006D9")]
	public RouteDataFlag flag; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40006DA")]
	public string routeName; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40006DB")]
	private Vector3[] _routePositions; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40006DC")]
	private RouteEvent[] _eventData; //Field offset: 0x50

	[Token(Token = "0x1700016A")]
	public RouteEvent[] eventData
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60007DC")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60007DD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000169")]
	public Vector3[] routePositions
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60007DA")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x60007DB")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1D50BC0", Offset = "0x1D4FFC0", Length = "0x84")]
	[Token(Token = "0x60007E1")]
	public RouteData() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60007DC")]
	public RouteEvent[] get_eventData() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60007DA")]
	public Vector3[] get_routePositions() { }

	[Address(RVA = "0x1D50A00", Offset = "0x1D4FE00", Length = "0x88")]
	[Token(Token = "0x60007DF")]
	public Vector3 LastPosition(Vector3 s) { }

	[Address(RVA = "0x1D50A90", Offset = "0x1D4FE90", Length = "0x8")]
	[Token(Token = "0x60007E0")]
	public void Reset() { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60007DD")]
	public void set_eventData(RouteEvent[] value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x60007DB")]
	public void set_routePositions(Vector3[] value) { }

	[Address(RVA = "0x1D50AA0", Offset = "0x1D4FEA0", Length = "0x11D")]
	[Token(Token = "0x60007DE")]
	public Vector3[] ToArray(Vector3 spos) { }

}

