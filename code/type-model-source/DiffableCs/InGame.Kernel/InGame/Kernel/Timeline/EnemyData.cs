namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000E2")]
public class EnemyData : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x20000E3")]
	private sealed class <>c
	{
		[Token(Token = "0x4000621")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000622")]
		public static Func<EnemyRepeatData, Int32> <>9__20_0; //Field offset: 0x8
		[Token(Token = "0x4000623")]
		public static Func<EnemyPlacementData, Single> <>9__30_0; //Field offset: 0x10
		[Token(Token = "0x4000624")]
		public static Func<RouteEvent, Boolean> <>9__30_1; //Field offset: 0x18
		[Token(Token = "0x4000625")]
		public static Func<RouteEvent, Single> <>9__30_2; //Field offset: 0x20

		[Address(RVA = "0x1D47840", Offset = "0x1D46C40", Length = "0x67")]
		[Token(Token = "0x6000763")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000764")]
		public <>c() { }

		[Address(RVA = "0x1D47750", Offset = "0x1D46B50", Length = "0x16")]
		[Token(Token = "0x6000765")]
		internal int <get_RepeatDataSum>b__20_0(EnemyRepeatData adata) { }

		[Address(RVA = "0x1D476B0", Offset = "0x1D46AB0", Length = "0x18")]
		[Token(Token = "0x6000766")]
		internal float <GetDuration>b__30_0(EnemyPlacementData n) { }

		[Address(RVA = "0x1D476D0", Offset = "0x1D46AD0", Length = "0x1A")]
		[Token(Token = "0x6000767")]
		internal bool <GetDuration>b__30_1(RouteEvent r) { }

		[Address(RVA = "0x1D476F0", Offset = "0x1D46AF0", Length = "0x24")]
		[Token(Token = "0x6000768")]
		internal float <GetDuration>b__30_2(RouteEvent e) { }

	}

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000614")]
	public int dataVersion; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000615")]
	public EnemyAttribute attribute; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000616")]
	public string objectName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000617")]
	public String[] routeNames; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Range(0.001, 1)]
	[SerializeField]
	[Token(Token = "0x4000618")]
	private float _smoothRotateValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000619")]
	public float durationTime; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400061A")]
	public Vector3 startPosition; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400061B")]
	public float invincibleTime; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400061C")]
	public float PlaneBaseY; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400061D")]
	public EnemyPlacementData[] placementDatas; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400061E")]
	public RouteEvent[] eventDatas; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400061F")]
	public EnemyRepeatData[] repeatDatas; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000620")]
	private Dictionary<String, Int32> _labelIndexs; //Field offset: 0x68

	[Token(Token = "0x1700015B")]
	private bool isCoordinate
	{
		[Address(RVA = "0x1D33240", Offset = "0x1D32640", Length = "0x9")]
		[Token(Token = "0x6000752")]
		private get { } //Length: 9
	}

	[Token(Token = "0x1700015C")]
	public int RepeatDataCount
	{
		[Address(RVA = "0x1D330E0", Offset = "0x1D324E0", Length = "0x12")]
		[Token(Token = "0x6000753")]
		 get { } //Length: 18
	}

	[Token(Token = "0x1700015D")]
	public int RepeatDataSum
	{
		[Address(RVA = "0x1D33100", Offset = "0x1D32500", Length = "0x12B")]
		[Token(Token = "0x6000754")]
		 get { } //Length: 299
	}

	[Token(Token = "0x1700015A")]
	public float SmoothRotateValue
	{
		[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
		[Token(Token = "0x6000751")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1D32FD0", Offset = "0x1D323D0", Length = "0x105")]
	[Token(Token = "0x600075C")]
	private List<String> _getStringValues(RouteEventType ttype) { }

	[Address(RVA = "0x1D32F50", Offset = "0x1D32350", Length = "0x7D")]
	[Token(Token = "0x6000762")]
	public EnemyData() { }

	[Address(RVA = "0x1D321E0", Offset = "0x1D315E0", Length = "0x103")]
	[Token(Token = "0x600075F")]
	public void Coordinate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000761")]
	public void DebugPrint(Vector3 spos) { }

	[Address(RVA = "0x1D33240", Offset = "0x1D32640", Length = "0x9")]
	[Token(Token = "0x6000752")]
	private bool get_isCoordinate() { }

	[Address(RVA = "0x1D330E0", Offset = "0x1D324E0", Length = "0x12")]
	[Token(Token = "0x6000753")]
	public int get_RepeatDataCount() { }

	[Address(RVA = "0x1D33100", Offset = "0x1D32500", Length = "0x12B")]
	[Token(Token = "0x6000754")]
	public int get_RepeatDataSum() { }

	[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
	[Token(Token = "0x6000751")]
	public float get_SmoothRotateValue() { }

	[Address(RVA = "0x1D322F0", Offset = "0x1D316F0", Length = "0x273")]
	[Token(Token = "0x600075B")]
	public List<String> GetBulletTemplateNames() { }

	[Address(RVA = "0x1D32570", Offset = "0x1D31970", Length = "0x361")]
	[Token(Token = "0x600075E")]
	public double GetDuration() { }

	[Address(RVA = "0x1D328E0", Offset = "0x1D31CE0", Length = "0x2B5")]
	[Token(Token = "0x6000759")]
	public List<String> GetEnemyNames() { }

	[Address(RVA = "0x1D32BA0", Offset = "0x1D31FA0", Length = "0xEB")]
	[Token(Token = "0x600075A")]
	public List<String> GetEnemyRoutes() { }

	[Address(RVA = "0x1D32C90", Offset = "0x1D32090", Length = "0x88")]
	[Token(Token = "0x600075D")]
	public int GetLabelIndex(string tlabel) { }

	[Address(RVA = "0x1D32D20", Offset = "0x1D32120", Length = "0x3D")]
	[Token(Token = "0x6000755")]
	public int GetLoopCount(int ncount) { }

	[Address(RVA = "0x1D32D60", Offset = "0x1D32160", Length = "0x48")]
	[Token(Token = "0x6000758")]
	public float GetRepeatDelay(int ncount, int nstep) { }

	[Address(RVA = "0x1D32DB0", Offset = "0x1D321B0", Length = "0xBE")]
	[Token(Token = "0x6000756")]
	public Vector3 GetRepeatOffset(int ncount, int nstep) { }

	[Address(RVA = "0x1D32E70", Offset = "0x1D32270", Length = "0x48")]
	[Token(Token = "0x6000757")]
	public float GetRepeatSpeed(int ncount, int nstep) { }

	[Address(RVA = "0x1D32EC0", Offset = "0x1D322C0", Length = "0x8F")]
	[Token(Token = "0x6000760")]
	public EnemyData ShallowCopy() { }

}

