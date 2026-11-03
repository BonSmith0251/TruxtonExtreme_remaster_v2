namespace UnityEngine.Timeline;

[Token(Token = "0x2000018")]
public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver
{
	[Token(Token = "0x200001C")]
	internal enum BlendCurveMode : int
	{
		Auto = 0,
		Manual = 1,
	}

	[Token(Token = "0x200001B")]
	internal enum ClipExtrapolation : int
	{
		None = 0,
		Hold = 1,
		Loop = 2,
		PingPong = 3,
		Continue = 4,
	}

	[Token(Token = "0x200001A")]
	private static class TimelineClipUpgrade
	{

		[Address(RVA = "0x2F352F0", Offset = "0x2F346F0", Length = "0x39")]
		[Token(Token = "0x6000109")]
		public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip) { }

	}

	[Token(Token = "0x2000019")]
	private enum Versions : int
	{
		Initial = 0,
		ClipInFromGlobalToLocal = 1,
	}

	[Token(Token = "0x4000060")]
	private const int k_LatestVersion = 1; //Field offset: 0x0
	[Token(Token = "0x4000062")]
	public static readonly ClipCaps kDefaultClipCaps; //Field offset: 0x0
	[Token(Token = "0x4000063")]
	public static readonly float kDefaultClipDurationInSeconds; //Field offset: 0x4
	[Token(Token = "0x4000064")]
	public static readonly double kTimeScaleMin; //Field offset: 0x8
	[Token(Token = "0x4000065")]
	public static readonly double kTimeScaleMax; //Field offset: 0x10
	[Token(Token = "0x4000066")]
	internal static readonly string kDefaultCurvesName; //Field offset: 0x18
	[Token(Token = "0x4000067")]
	internal static readonly double kMinDuration; //Field offset: 0x20
	[Token(Token = "0x4000068")]
	internal static readonly double kMaxTimeValue; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000061")]
	private int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000069")]
	private double m_Start; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400006A")]
	private double m_ClipIn; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400006B")]
	private object m_Asset; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_HackDuration")]
	[SerializeField]
	[Token(Token = "0x400006C")]
	private double m_Duration; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400006D")]
	private double m_TimeScale; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400006E")]
	private TrackAsset m_ParentTrack; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400006F")]
	private double m_EaseInDuration; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000070")]
	private double m_EaseOutDuration; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000071")]
	private double m_BlendInDuration; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000072")]
	private double m_BlendOutDuration; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000073")]
	private AnimationCurve m_MixInCurve; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000074")]
	private AnimationCurve m_MixOutCurve; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000075")]
	private BlendCurveMode m_BlendInCurveMode; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x4000076")]
	private BlendCurveMode m_BlendOutCurveMode; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000077")]
	private List<String> m_ExposedParameterNames; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000078")]
	private AnimationClip m_AnimationCurves; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000079")]
	private bool m_Recordable; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	[Token(Token = "0x400007A")]
	private ClipExtrapolation m_PostExtrapolationMode; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x400007B")]
	private ClipExtrapolation m_PreExtrapolationMode; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x400007C")]
	private double m_PostExtrapolationTime; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x400007D")]
	private double m_PreExtrapolationTime; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x400007E")]
	private string m_DisplayName; //Field offset: 0xB0

	[Token(Token = "0x1700005B")]
	public AnimationClip animationClip
	{
		[Address(RVA = "0x2F36790", Offset = "0x2F35B90", Length = "0xEF")]
		[Token(Token = "0x60000F3")]
		 get { } //Length: 239
	}

	[Token(Token = "0x17000042")]
	public override object asset
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60000C4")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60000C5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700004D")]
	public BlendCurveMode blendInCurveMode
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x60000D8")]
		 get { } //Length: 4
		[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
		[Token(Token = "0x60000D9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700004B")]
	public double blendInDuration
	{
		[Address(RVA = "0x2F36880", Offset = "0x2F35C80", Length = "0x28")]
		[Token(Token = "0x60000D4")]
		 get { } //Length: 40
		[Address(RVA = "0x2F37390", Offset = "0x2F36790", Length = "0x8C")]
		[Token(Token = "0x60000D5")]
		 set { } //Length: 140
	}

	[Token(Token = "0x1700004E")]
	public BlendCurveMode blendOutCurveMode
	{
		[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
		[Token(Token = "0x60000DA")]
		 get { } //Length: 4
		[Address(RVA = "0x1D16670", Offset = "0x1D15A70", Length = "0x4")]
		[Token(Token = "0x60000DB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700004C")]
	public double blendOutDuration
	{
		[Address(RVA = "0x2F368B0", Offset = "0x2F35CB0", Length = "0x28")]
		[Token(Token = "0x60000D6")]
		 get { } //Length: 40
		[Address(RVA = "0x2F37420", Offset = "0x2F36820", Length = "0x8C")]
		[Token(Token = "0x60000D7")]
		 set { } //Length: 140
	}

	[Token(Token = "0x1700003E")]
	public double clipAssetDuration
	{
		[Address(RVA = "0x2F368E0", Offset = "0x2F35CE0", Length = "0x61")]
		[Token(Token = "0x60000BF")]
		 get { } //Length: 97
	}

	[Token(Token = "0x1700005A")]
	public ClipCaps clipCaps
	{
		[Address(RVA = "0x2F36950", Offset = "0x2F35D50", Length = "0x8A")]
		[Token(Token = "0x60000EA")]
		 get { } //Length: 138
	}

	[Token(Token = "0x1700003C")]
	public double clipIn
	{
		[Address(RVA = "0x2F369E0", Offset = "0x2F35DE0", Length = "0x28")]
		[Token(Token = "0x60000BB")]
		 get { } //Length: 40
		[Address(RVA = "0x2F374B0", Offset = "0x2F368B0", Length = "0xDC")]
		[Token(Token = "0x60000BC")]
		 set { } //Length: 220
	}

	[Token(Token = "0x1700003F")]
	public internal override AnimationClip curves
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x60000C0")]
		 get { } //Length: 8
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[Token(Token = "0x60000C1")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700003D")]
	public string displayName
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[Token(Token = "0x60000BD")]
		 get { } //Length: 8
		[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
		[Token(Token = "0x60000BE")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700003A")]
	public override double duration
	{
		[Address(RVA = "0x2A0B030", Offset = "0x2A0A430", Length = "0x6")]
		[Token(Token = "0x60000B8")]
		 get { } //Length: 6
		[Address(RVA = "0x2F37590", Offset = "0x2F36990", Length = "0x120")]
		[Token(Token = "0x60000B9")]
		 set { } //Length: 288
	}

	[Token(Token = "0x17000047")]
	public double easeInDuration
	{
		[Address(RVA = "0x2F36A10", Offset = "0x2F35E10", Length = "0xC5")]
		[Token(Token = "0x60000CE")]
		 get { } //Length: 197
		[Address(RVA = "0x2F376C0", Offset = "0x2F36AC0", Length = "0x10D")]
		[Token(Token = "0x60000CF")]
		 set { } //Length: 269
	}

	[Token(Token = "0x17000048")]
	public double easeOutDuration
	{
		[Address(RVA = "0x2F36AE0", Offset = "0x2F35EE0", Length = "0xC5")]
		[Token(Token = "0x60000D0")]
		 get { } //Length: 197
		[Address(RVA = "0x2F377D0", Offset = "0x2F36BD0", Length = "0x10D")]
		[Token(Token = "0x60000D1")]
		 set { } //Length: 269
	}

	[Token(Token = "0x1700004A")]
	public double easeOutTime
	{
		[Address(RVA = "0x2F36BB0", Offset = "0x2F35FB0", Length = "0x31")]
		[Token(Token = "0x60000D3")]
		 get { } //Length: 49
	}

	[Obsolete("Use easeOutTime instead (UnityUpgradable) -> easeOutTime", True)]
	[Token(Token = "0x17000049")]
	public double eastOutTime
	{
		[Address(RVA = "0x2F36BB0", Offset = "0x2F35FB0", Length = "0x31")]
		[Token(Token = "0x60000D2")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700003B")]
	public double end
	{
		[Address(RVA = "0x2F36BF0", Offset = "0x2F35FF0", Length = "0xB")]
		[Token(Token = "0x60000BA")]
		 get { } //Length: 11
	}

	[Obsolete("exposedParameter is deprecated and will be removed in a future release", True)]
	[Token(Token = "0x17000059")]
	public List<String> exposedParameters
	{
		[Address(RVA = "0x2F36C00", Offset = "0x2F36000", Length = "0x84")]
		[Token(Token = "0x60000E9")]
		 get { } //Length: 132
	}

	[Token(Token = "0x1700005F")]
	public double extrapolatedDuration
	{
		[Address(RVA = "0x2F36C90", Offset = "0x2F36090", Length = "0xD5")]
		[Token(Token = "0x60000FF")]
		 get { } //Length: 213
	}

	[Token(Token = "0x1700005E")]
	public double extrapolatedStart
	{
		[Address(RVA = "0x2F36D70", Offset = "0x2F36170", Length = "0x17")]
		[Token(Token = "0x60000FE")]
		 get { } //Length: 23
	}

	[Token(Token = "0x1700004F")]
	public bool hasBlendIn
	{
		[Address(RVA = "0x2F36D90", Offset = "0x2F36190", Length = "0x31")]
		[Token(Token = "0x60000DC")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000050")]
	public bool hasBlendOut
	{
		[Address(RVA = "0x2F36DD0", Offset = "0x2F361D0", Length = "0x31")]
		[Token(Token = "0x60000DD")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000041")]
	public override bool hasCurves
	{
		[Address(RVA = "0x2F36E10", Offset = "0x2F36210", Length = "0x86")]
		[Token(Token = "0x60000C3")]
		 get { } //Length: 134
	}

	[Token(Token = "0x17000037")]
	public bool hasPostExtrapolation
	{
		[Address(RVA = "0x2F36EA0", Offset = "0x2F362A0", Length = "0x1F")]
		[Token(Token = "0x60000B3")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000036")]
	public bool hasPreExtrapolation
	{
		[Address(RVA = "0x2F36EC0", Offset = "0x2F362C0", Length = "0x1F")]
		[Token(Token = "0x60000B2")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000051")]
	public AnimationCurve mixInCurve
	{
		[Address(RVA = "0x2F36EE0", Offset = "0x2F362E0", Length = "0x8A")]
		[Token(Token = "0x60000DE")]
		 get { } //Length: 138
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x60000DF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000053")]
	public double mixInDuration
	{
		[Address(RVA = "0x2F36F70", Offset = "0x2F36370", Length = "0xF4")]
		[Token(Token = "0x60000E1")]
		 get { } //Length: 244
	}

	[Token(Token = "0x17000052")]
	public float mixInPercentage
	{
		[Address(RVA = "0x2F37070", Offset = "0x2F36470", Length = "0x1F")]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000054")]
	public AnimationCurve mixOutCurve
	{
		[Address(RVA = "0x2F37090", Offset = "0x2F36490", Length = "0x8A")]
		[Token(Token = "0x60000E2")]
		 get { } //Length: 138
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x60000E3")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000056")]
	public double mixOutDuration
	{
		[Address(RVA = "0x2F37120", Offset = "0x2F36520", Length = "0x5C")]
		[Token(Token = "0x60000E5")]
		 get { } //Length: 92
	}

	[Token(Token = "0x17000057")]
	public float mixOutPercentage
	{
		[Address(RVA = "0x2F37180", Offset = "0x2F36580", Length = "0x60")]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 96
	}

	[Token(Token = "0x17000055")]
	public double mixOutTime
	{
		[Address(RVA = "0x2F371E0", Offset = "0x2F365E0", Length = "0x6F")]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 111
	}

	[Obsolete("parentTrack is deprecated and will be removed in a future release. Use GetParentTrack() and TimelineClipExtensions::MoveToTrack() or TimelineClipExtensions::TryMoveToTrack() instead.", False)]
	[Token(Token = "0x17000046")]
	public TrackAsset parentTrack
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60000CA")]
		 get { } //Length: 5
		[Address(RVA = "0x2F378E0", Offset = "0x2F36CE0", Length = "0x8")]
		[Token(Token = "0x60000CB")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700005C")]
	public internal ClipExtrapolation postExtrapolationMode
	{
		[Address(RVA = "0x2F37250", Offset = "0x2F36650", Length = "0x28")]
		[Token(Token = "0x60000F5")]
		 get { } //Length: 40
		[Address(RVA = "0x2F378F0", Offset = "0x2F36CF0", Length = "0x3B")]
		[Token(Token = "0x60000F6")]
		internal set { } //Length: 59
	}

	[Token(Token = "0x1700005D")]
	public internal ClipExtrapolation preExtrapolationMode
	{
		[Address(RVA = "0x2F37280", Offset = "0x2F36680", Length = "0x28")]
		[Token(Token = "0x60000F7")]
		 get { } //Length: 40
		[Address(RVA = "0x2F37930", Offset = "0x2F36D30", Length = "0x3B")]
		[Token(Token = "0x60000F8")]
		internal set { } //Length: 59
	}

	[Token(Token = "0x17000058")]
	public internal bool recordable
	{
		[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
		[Token(Token = "0x60000E7")]
		 get { } //Length: 8
		[Address(RVA = "0xE26D90", Offset = "0xE26190", Length = "0x7")]
		[Token(Token = "0x60000E8")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000039")]
	public double start
	{
		[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
		[Token(Token = "0x60000B6")]
		 get { } //Length: 6
		[Address(RVA = "0x2F37970", Offset = "0x2F36D70", Length = "0x16A")]
		[Token(Token = "0x60000B7")]
		 set { } //Length: 362
	}

	[Token(Token = "0x17000038")]
	public double timeScale
	{
		[Address(RVA = "0x2F372B0", Offset = "0x2F366B0", Length = "0xDB")]
		[Token(Token = "0x60000B4")]
		 get { } //Length: 219
		[Address(RVA = "0x2F37AE0", Offset = "0x2F36EE0", Length = "0xE1")]
		[Token(Token = "0x60000B5")]
		 set { } //Length: 225
	}

	[Obsolete("underlyingAsset property is obsolete. Use asset property instead", True)]
	[Token(Token = "0x17000045")]
	public object underlyingAsset
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60000C8")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60000C9")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000043")]
	private override object UnityEngine.Timeline.ICurvesOwner.assetOwner
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60000C6")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000040")]
	private override string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName
	{
		[Address(RVA = "0x2F365E0", Offset = "0x2F359E0", Length = "0x4F")]
		[Token(Token = "0x60000C2")]
		private get { } //Length: 79
	}

	[Token(Token = "0x17000044")]
	private override TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60000C7")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x2F36630", Offset = "0x2F35A30", Length = "0x101")]
	[Token(Token = "0x6000108")]
	private static TimelineClip() { }

	[Address(RVA = "0x2F36740", Offset = "0x2F35B40", Length = "0x4F")]
	[Token(Token = "0x60000B1")]
	internal TimelineClip(TrackAsset parent) { }

	[Address(RVA = "0x2F35330", Offset = "0x2F34730", Length = "0xE3")]
	[Token(Token = "0x6000106")]
	private static double CalculateEasingRatio(double easeIn, double easeOut) { }

	[Address(RVA = "0x2F35420", Offset = "0x2F34820", Length = "0x14E")]
	[Token(Token = "0x6000105")]
	public void ConformEaseValues() { }

	[Address(RVA = "0x2F35570", Offset = "0x2F34970", Length = "0xDA")]
	[Token(Token = "0x6000101")]
	public override void CreateCurves(string curvesClipName) { }

	[Address(RVA = "0x2F35650", Offset = "0x2F34A50", Length = "0x161")]
	[Token(Token = "0x60000ED")]
	public float EvaluateMixIn(double time) { }

	[Address(RVA = "0x2F357C0", Offset = "0x2F34BC0", Length = "0x1FB")]
	[Token(Token = "0x60000EC")]
	public float EvaluateMixOut(double time) { }

	[Address(RVA = "0x2F359C0", Offset = "0x2F34DC0", Length = "0x55")]
	[Token(Token = "0x60000F2")]
	internal double FromLocalTimeUnbound(double time) { }

	[Address(RVA = "0x2F36790", Offset = "0x2F35B90", Length = "0xEF")]
	[Token(Token = "0x60000F3")]
	public AnimationClip get_animationClip() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60000C4")]
	public override object get_asset() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x60000D8")]
	public BlendCurveMode get_blendInCurveMode() { }

	[Address(RVA = "0x2F36880", Offset = "0x2F35C80", Length = "0x28")]
	[Token(Token = "0x60000D4")]
	public double get_blendInDuration() { }

	[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
	[Token(Token = "0x60000DA")]
	public BlendCurveMode get_blendOutCurveMode() { }

	[Address(RVA = "0x2F368B0", Offset = "0x2F35CB0", Length = "0x28")]
	[Token(Token = "0x60000D6")]
	public double get_blendOutDuration() { }

	[Address(RVA = "0x2F368E0", Offset = "0x2F35CE0", Length = "0x61")]
	[Token(Token = "0x60000BF")]
	public double get_clipAssetDuration() { }

	[Address(RVA = "0x2F36950", Offset = "0x2F35D50", Length = "0x8A")]
	[Token(Token = "0x60000EA")]
	public ClipCaps get_clipCaps() { }

	[Address(RVA = "0x2F369E0", Offset = "0x2F35DE0", Length = "0x28")]
	[Token(Token = "0x60000BB")]
	public double get_clipIn() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x60000C0")]
	public override AnimationClip get_curves() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[Token(Token = "0x60000BD")]
	public string get_displayName() { }

	[Address(RVA = "0x2A0B030", Offset = "0x2A0A430", Length = "0x6")]
	[Token(Token = "0x60000B8")]
	public override double get_duration() { }

	[Address(RVA = "0x2F36A10", Offset = "0x2F35E10", Length = "0xC5")]
	[Token(Token = "0x60000CE")]
	public double get_easeInDuration() { }

	[Address(RVA = "0x2F36AE0", Offset = "0x2F35EE0", Length = "0xC5")]
	[Token(Token = "0x60000D0")]
	public double get_easeOutDuration() { }

	[Address(RVA = "0x2F36BB0", Offset = "0x2F35FB0", Length = "0x31")]
	[Token(Token = "0x60000D3")]
	public double get_easeOutTime() { }

	[Address(RVA = "0x2F36BB0", Offset = "0x2F35FB0", Length = "0x31")]
	[Token(Token = "0x60000D2")]
	public double get_eastOutTime() { }

	[Address(RVA = "0x2F36BF0", Offset = "0x2F35FF0", Length = "0xB")]
	[Token(Token = "0x60000BA")]
	public double get_end() { }

	[Address(RVA = "0x2F36C00", Offset = "0x2F36000", Length = "0x84")]
	[Token(Token = "0x60000E9")]
	public List<String> get_exposedParameters() { }

	[Address(RVA = "0x2F36C90", Offset = "0x2F36090", Length = "0xD5")]
	[Token(Token = "0x60000FF")]
	public double get_extrapolatedDuration() { }

	[Address(RVA = "0x2F36D70", Offset = "0x2F36170", Length = "0x17")]
	[Token(Token = "0x60000FE")]
	public double get_extrapolatedStart() { }

	[Address(RVA = "0x2F36D90", Offset = "0x2F36190", Length = "0x31")]
	[Token(Token = "0x60000DC")]
	public bool get_hasBlendIn() { }

	[Address(RVA = "0x2F36DD0", Offset = "0x2F361D0", Length = "0x31")]
	[Token(Token = "0x60000DD")]
	public bool get_hasBlendOut() { }

	[Address(RVA = "0x2F36E10", Offset = "0x2F36210", Length = "0x86")]
	[Token(Token = "0x60000C3")]
	public override bool get_hasCurves() { }

	[Address(RVA = "0x2F36EA0", Offset = "0x2F362A0", Length = "0x1F")]
	[Token(Token = "0x60000B3")]
	public bool get_hasPostExtrapolation() { }

	[Address(RVA = "0x2F36EC0", Offset = "0x2F362C0", Length = "0x1F")]
	[Token(Token = "0x60000B2")]
	public bool get_hasPreExtrapolation() { }

	[Address(RVA = "0x2F36EE0", Offset = "0x2F362E0", Length = "0x8A")]
	[Token(Token = "0x60000DE")]
	public AnimationCurve get_mixInCurve() { }

	[Address(RVA = "0x2F36F70", Offset = "0x2F36370", Length = "0xF4")]
	[Token(Token = "0x60000E1")]
	public double get_mixInDuration() { }

	[Address(RVA = "0x2F37070", Offset = "0x2F36470", Length = "0x1F")]
	[Token(Token = "0x60000E0")]
	public float get_mixInPercentage() { }

	[Address(RVA = "0x2F37090", Offset = "0x2F36490", Length = "0x8A")]
	[Token(Token = "0x60000E2")]
	public AnimationCurve get_mixOutCurve() { }

	[Address(RVA = "0x2F37120", Offset = "0x2F36520", Length = "0x5C")]
	[Token(Token = "0x60000E5")]
	public double get_mixOutDuration() { }

	[Address(RVA = "0x2F37180", Offset = "0x2F36580", Length = "0x60")]
	[Token(Token = "0x60000E6")]
	public float get_mixOutPercentage() { }

	[Address(RVA = "0x2F371E0", Offset = "0x2F365E0", Length = "0x6F")]
	[Token(Token = "0x60000E4")]
	public double get_mixOutTime() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60000CA")]
	public TrackAsset get_parentTrack() { }

	[Address(RVA = "0x2F37250", Offset = "0x2F36650", Length = "0x28")]
	[Token(Token = "0x60000F5")]
	public ClipExtrapolation get_postExtrapolationMode() { }

	[Address(RVA = "0x2F37280", Offset = "0x2F36680", Length = "0x28")]
	[Token(Token = "0x60000F7")]
	public ClipExtrapolation get_preExtrapolationMode() { }

	[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
	[Token(Token = "0x60000E7")]
	public bool get_recordable() { }

	[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
	[Token(Token = "0x60000B6")]
	public double get_start() { }

	[Address(RVA = "0x2F372B0", Offset = "0x2F366B0", Length = "0xDB")]
	[Token(Token = "0x60000B4")]
	public double get_timeScale() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60000C8")]
	public object get_underlyingAsset() { }

	[Address(RVA = "0x2F35A20", Offset = "0x2F34E20", Length = "0x28")]
	[Token(Token = "0x60000EE")]
	private static AnimationCurve GetDefaultMixInCurve() { }

	[Address(RVA = "0x2F35A50", Offset = "0x2F34E50", Length = "0x28")]
	[Token(Token = "0x60000EF")]
	private static AnimationCurve GetDefaultMixOutCurve() { }

	[Address(RVA = "0x2F35A80", Offset = "0x2F34E80", Length = "0x135")]
	[Token(Token = "0x6000100")]
	private static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60000CC")]
	public TrackAsset GetParentTrack() { }

	[Address(RVA = "0x2F35BC0", Offset = "0x2F34FC0", Length = "0x107")]
	[Token(Token = "0x60000EB")]
	internal int Hash() { }

	[Address(RVA = "0x2F35CD0", Offset = "0x2F350D0", Length = "0xA7")]
	[Token(Token = "0x60000FB")]
	public bool IsExtrapolatedTime(double sequenceTime) { }

	[Address(RVA = "0x2F35D80", Offset = "0x2F35180", Length = "0x6A")]
	[Token(Token = "0x60000FD")]
	public bool IsPostExtrapolatedTime(double sequenceTime) { }

	[Address(RVA = "0x2F35DF0", Offset = "0x2F351F0", Length = "0x57")]
	[Token(Token = "0x60000FC")]
	public bool IsPreExtrapolatedTime(double sequenceTime) { }

	[Address(RVA = "0x2F35E50", Offset = "0x2F35250", Length = "0x135")]
	[Token(Token = "0x60000F4")]
	private static double SanitizeTimeValue(double value, double defaultValue) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60000C5")]
	public void set_asset(object value) { }

	[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
	[Token(Token = "0x60000D9")]
	public void set_blendInCurveMode(BlendCurveMode value) { }

	[Address(RVA = "0x2F37390", Offset = "0x2F36790", Length = "0x8C")]
	[Token(Token = "0x60000D5")]
	public void set_blendInDuration(double value) { }

	[Address(RVA = "0x1D16670", Offset = "0x1D15A70", Length = "0x4")]
	[Token(Token = "0x60000DB")]
	public void set_blendOutCurveMode(BlendCurveMode value) { }

	[Address(RVA = "0x2F37420", Offset = "0x2F36820", Length = "0x8C")]
	[Token(Token = "0x60000D7")]
	public void set_blendOutDuration(double value) { }

	[Address(RVA = "0x2F374B0", Offset = "0x2F368B0", Length = "0xDC")]
	[Token(Token = "0x60000BC")]
	public void set_clipIn(double value) { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[Token(Token = "0x60000C1")]
	internal void set_curves(AnimationClip value) { }

	[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
	[Token(Token = "0x60000BE")]
	public void set_displayName(string value) { }

	[Address(RVA = "0x2F37590", Offset = "0x2F36990", Length = "0x120")]
	[Token(Token = "0x60000B9")]
	public void set_duration(double value) { }

	[Address(RVA = "0x2F376C0", Offset = "0x2F36AC0", Length = "0x10D")]
	[Token(Token = "0x60000CF")]
	public void set_easeInDuration(double value) { }

	[Address(RVA = "0x2F377D0", Offset = "0x2F36BD0", Length = "0x10D")]
	[Token(Token = "0x60000D1")]
	public void set_easeOutDuration(double value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x60000DF")]
	public void set_mixInCurve(AnimationCurve value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x60000E3")]
	public void set_mixOutCurve(AnimationCurve value) { }

	[Address(RVA = "0x2F378E0", Offset = "0x2F36CE0", Length = "0x8")]
	[Token(Token = "0x60000CB")]
	public void set_parentTrack(TrackAsset value) { }

	[Address(RVA = "0x2F378F0", Offset = "0x2F36CF0", Length = "0x3B")]
	[Token(Token = "0x60000F6")]
	internal void set_postExtrapolationMode(ClipExtrapolation value) { }

	[Address(RVA = "0x2F37930", Offset = "0x2F36D30", Length = "0x3B")]
	[Token(Token = "0x60000F8")]
	internal void set_preExtrapolationMode(ClipExtrapolation value) { }

	[Address(RVA = "0xE26D90", Offset = "0xE26190", Length = "0x7")]
	[Token(Token = "0x60000E8")]
	internal void set_recordable(bool value) { }

	[Address(RVA = "0x2F37970", Offset = "0x2F36D70", Length = "0x16A")]
	[Token(Token = "0x60000B7")]
	public void set_start(double value) { }

	[Address(RVA = "0x2F37AE0", Offset = "0x2F36EE0", Length = "0xE1")]
	[Token(Token = "0x60000B5")]
	public void set_timeScale(double value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C9")]
	public void set_underlyingAsset(object value) { }

	[Address(RVA = "0x2F35F90", Offset = "0x2F35390", Length = "0x15A")]
	[Token(Token = "0x60000CD")]
	internal void SetParentTrack_Internal(TrackAsset newParentTrack) { }

	[Address(RVA = "0x2F360F0", Offset = "0x2F354F0", Length = "0x9")]
	[Token(Token = "0x60000F9")]
	internal void SetPostExtrapolationTime(double time) { }

	[Address(RVA = "0x2F36100", Offset = "0x2F35500", Length = "0x9")]
	[Token(Token = "0x60000FA")]
	internal void SetPreExtrapolationTime(double time) { }

	[Address(RVA = "0x2F36180", Offset = "0x2F35580", Length = "0x1BA")]
	[Token(Token = "0x60000F0")]
	public double ToLocalTime(double time) { }

	[Address(RVA = "0x2F36110", Offset = "0x2F35510", Length = "0x6A")]
	[Token(Token = "0x60000F1")]
	public double ToLocalTimeUnbound(double time) { }

	[Address(RVA = "0x2F36340", Offset = "0x2F35740", Length = "0x254")]
	[Token(Token = "0x6000104")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F365A0", Offset = "0x2F359A0", Length = "0x2D")]
	[Token(Token = "0x6000103")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x2F365D0", Offset = "0x2F359D0", Length = "0x8")]
	[Token(Token = "0x6000102")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60000C6")]
	private override object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	[Address(RVA = "0x2F365E0", Offset = "0x2F359E0", Length = "0x4F")]
	[Token(Token = "0x60000C2")]
	private override string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60000C7")]
	private override TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000107")]
	private void UpdateDirty(double oldValue, double newValue) { }

	[Address(RVA = "0x2F365A0", Offset = "0x2F359A0", Length = "0x2D")]
	[Token(Token = "0x60000B0")]
	private void UpgradeToLatestVersion() { }

}

