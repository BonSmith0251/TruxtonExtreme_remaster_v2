namespace UnityEngine.Splines;

[AddComponentMenu("Splines/Spline Animate")]
[ExecuteInEditMode]
[Token(Token = "0x2000024")]
public class SplineAnimate : SplineComponent
{
	[Token(Token = "0x2000028")]
	internal enum AlignmentMode : int
	{
		None = 0,
		SplineElement = 1,
		SplineObject = 2,
		World = 3,
	}

	[Token(Token = "0x2000027")]
	internal enum EasingMode : int
	{
		None = 0,
		EaseIn = 1,
		EaseOut = 2,
		EaseInOut = 3,
	}

	[Token(Token = "0x2000026")]
	internal enum LoopMode : int
	{
		Once = 0,
		Loop = 1,
		LoopEaseInOnce = 2,
		PingPong = 3,
	}

	[Token(Token = "0x2000025")]
	internal enum Method : int
	{
		Time = 0,
		Speed = 1,
	}

	[Token(Token = "0x4000083")]
	internal static readonly string k_EmptyContainerError; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400006D")]
	[Tooltip("The target spline to follow.")]
	private SplineContainer m_Target; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400006E")]
	[Tooltip("Enable to have the animation start when the GameObject first loads.")]
	private bool m_PlayOnAwake; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400006F")]
	[Tooltip("The loop mode that the animation uses. Loop modes cause the animation to repeat after it finishes. The following loop modes are available:.\nOnce - Traverse the spline once and stop at the end.\nLoop Continuous - Traverse the spline continuously without stopping.\nEase In Then Continuous - Traverse the spline repeatedly without stopping. If Ease In easing is enabled, apply easing to the first loop only.\nPing Pong - Traverse the spline continuously without stopping and reverse direction after an end of the spline is reached.\n")]
	private LoopMode m_LoopMode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000070")]
	[Tooltip("The method used to animate the GameObject along the spline.\nTime - The spline is traversed in a given amount of seconds.\nSpeed - The spline is traversed at a given maximum speed.")]
	private Method m_Method; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000071")]
	[Tooltip("The period of time that it takes for the GameObject to complete its animation along the spline.")]
	private float m_Duration; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000072")]
	[Tooltip("The speed in meters/second that the GameObject animates along the spline at.")]
	private float m_MaxSpeed; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000073")]
	[Tooltip("The easing mode used when the GameObject animates along the spline.\nNone - Apply no easing to the animation. The animation speed is linear.\nEase In Only - Apply easing to the beginning of animation.\nEase Out Only - Apply easing to the end of animation.\nEase In-Out - Apply easing to the beginning and end of animation.\n")]
	private EasingMode m_EasingMode; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000074")]
	[Tooltip("The coordinate space that the GameObject's up and forward axes align to.")]
	private AlignmentMode m_AlignmentMode; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000075")]
	[Tooltip("Which axis of the GameObject is treated as the forward axis.")]
	private AlignAxis m_ObjectForwardAxis; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000076")]
	[Tooltip("Which axis of the GameObject is treated as the up axis.")]
	private AlignAxis m_ObjectUpAxis; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x4000077")]
	[Tooltip("Normalized distance [0;1] offset along the spline at which the GameObject should be placed when the animation begins.")]
	private float m_StartOffset; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000078")]
	private float m_StartOffsetT; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000079")]
	private bool m_PlayOnAwakeHandledForSession; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400007A")]
	private float m_SplineLength; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400007B")]
	private bool m_Playing; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400007C")]
	private float m_NormalizedTime; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400007D")]
	private float m_ElapsedTime; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400007E")]
	private SplinePath<Spline> m_SplinePath; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400007F")]
	private Action<Vector3, Quaternion> onUpdated; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000080")]
	private Action<Vector3, Quaternion> Updated; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000081")]
	private bool m_EndReached; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000082")]
	private Action Completed; //Field offset: 0x90

	[Token(Token = "0x14000005")]
	public event Action Completed
	{
		[Address(RVA = "0x2E5EA20", Offset = "0x2E5DE20", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6000155")]
		 add { } //Length: 162
		[Address(RVA = "0x2E5EC40", Offset = "0x2E5E040", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6000156")]
		 remove { } //Length: 162
	}

	[Obsolete("Use Updated instead.", False)]
	[Token(Token = "0x14000003")]
	public event Action<Vector3, Quaternion> onUpdated
	{
		[Address(RVA = "0x2E5EB90", Offset = "0x2E5DF90", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000151")]
		 add { } //Length: 172
		[Address(RVA = "0x2E5EDB0", Offset = "0x2E5E1B0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000152")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x14000004")]
	public event Action<Vector3, Quaternion> Updated
	{
		[Address(RVA = "0x2E5EAD0", Offset = "0x2E5DED0", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x6000153")]
		 add { } //Length: 186
		[Address(RVA = "0x2E5ECF0", Offset = "0x2E5E0F0", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x6000154")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x17000042")]
	public AlignmentMode Alignment
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x600013E")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[Token(Token = "0x600013F")]
		 set { } //Length: 4
	}

	[Obsolete("Use Alignment instead.", False)]
	[Token(Token = "0x17000041")]
	public AlignmentMode alignmentMode
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x600013D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700003A")]
	public Method AnimationMethod
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000132")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x6000133")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000034")]
	public SplineContainer Container
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000129")]
		 get { } //Length: 5
		[Address(RVA = "0x2E5EE60", Offset = "0x2E5E260", Length = "0x2FB")]
		[Token(Token = "0x600012A")]
		 set { } //Length: 763
	}

	[Obsolete("Use Duration instead.", False)]
	[Token(Token = "0x1700003B")]
	public float duration
	{
		[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
		[Token(Token = "0x6000134")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700003C")]
	public float Duration
	{
		[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
		[Token(Token = "0x6000135")]
		 get { } //Length: 6
		[Address(RVA = "0x2E5F160", Offset = "0x2E5E560", Length = "0x1A")]
		[Token(Token = "0x6000136")]
		 set { } //Length: 26
	}

	[Token(Token = "0x17000040")]
	public EasingMode Easing
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x600013B")]
		 get { } //Length: 4
		[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
		[Token(Token = "0x600013C")]
		 set { } //Length: 4
	}

	[Obsolete("Use Easing instead.", False)]
	[Token(Token = "0x1700003F")]
	public EasingMode easingMode
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x600013A")]
		 get { } //Length: 4
	}

	[Obsolete("Use ElapsedTime instead.", False)]
	[Token(Token = "0x17000049")]
	public float elapsedTime
	{
		[Address(RVA = "0x16D0800", Offset = "0x16CFC00", Length = "0x6")]
		[Token(Token = "0x6000149")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700004A")]
	public float ElapsedTime
	{
		[Address(RVA = "0x16D0800", Offset = "0x16CFC00", Length = "0x6")]
		[Token(Token = "0x600014A")]
		 get { } //Length: 6
		[Address(RVA = "0x2E5F180", Offset = "0x2E5E580", Length = "0x28")]
		[Token(Token = "0x600014B")]
		 set { } //Length: 40
	}

	[Obsolete("Use IsPlaying instead.", False)]
	[Token(Token = "0x1700004D")]
	public bool isPlaying
	{
		[Address(RVA = "0x29B71F0", Offset = "0x29B65F0", Length = "0x5")]
		[Token(Token = "0x600014F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004E")]
	public bool IsPlaying
	{
		[Address(RVA = "0x29B71F0", Offset = "0x29B65F0", Length = "0x5")]
		[Token(Token = "0x6000150")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000038")]
	public LoopMode Loop
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x600012F")]
		 get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[Token(Token = "0x6000130")]
		 set { } //Length: 4
	}

	[Obsolete("Use Loop instead.", False)]
	[Token(Token = "0x17000037")]
	public LoopMode loopMode
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x600012E")]
		 get { } //Length: 4
	}

	[Obsolete("Use MaxSpeed instead.", False)]
	[Token(Token = "0x1700003D")]
	public float maxSpeed
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[Token(Token = "0x6000137")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700003E")]
	public float MaxSpeed
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[Token(Token = "0x6000138")]
		 get { } //Length: 6
		[Address(RVA = "0x2E5F1B0", Offset = "0x2E5E5B0", Length = "0x1A")]
		[Token(Token = "0x6000139")]
		 set { } //Length: 26
	}

	[Obsolete("Use AnimationMethod instead.", False)]
	[Token(Token = "0x17000039")]
	public Method method
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000131")]
		 get { } //Length: 4
	}

	[Obsolete("Use NormalizedTime instead.", False)]
	[Token(Token = "0x17000047")]
	public float normalizedTime
	{
		[Address(RVA = "0x16D0A10", Offset = "0x16CFE10", Length = "0x6")]
		[Token(Token = "0x6000146")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000048")]
	public float NormalizedTime
	{
		[Address(RVA = "0x16D0A10", Offset = "0x16CFE10", Length = "0x6")]
		[Token(Token = "0x6000147")]
		 get { } //Length: 6
		[Address(RVA = "0x2E5F1D0", Offset = "0x2E5E5D0", Length = "0x5C")]
		[Token(Token = "0x6000148")]
		 set { } //Length: 92
	}

	[Obsolete("Use ObjectForwardAxis instead.", False)]
	[Token(Token = "0x17000043")]
	public AlignAxis objectForwardAxis
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x6000140")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000044")]
	public AlignAxis ObjectForwardAxis
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x6000141")]
		 get { } //Length: 4
		[Address(RVA = "0x2E5F230", Offset = "0x2E5E630", Length = "0x5A")]
		[Token(Token = "0x6000142")]
		 set { } //Length: 90
	}

	[Obsolete("Use ObjectUpAxis instead.", False)]
	[Token(Token = "0x17000045")]
	public AlignAxis objectUpAxis
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x6000143")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000046")]
	public AlignAxis ObjectUpAxis
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x6000144")]
		 get { } //Length: 4
		[Address(RVA = "0x2E5F290", Offset = "0x2E5E690", Length = "0x5A")]
		[Token(Token = "0x6000145")]
		 set { } //Length: 90
	}

	[Obsolete("Use PlayOnAwake instead.", False)]
	[Token(Token = "0x17000035")]
	public bool playOnAwake
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x600012B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000036")]
	public bool PlayOnAwake
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x600012C")]
		 get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[Token(Token = "0x600012D")]
		 set { } //Length: 4
	}

	[Obsolete("Use Container instead.", False)]
	[Token(Token = "0x17000033")]
	public SplineContainer splineContainer
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000128")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004B")]
	public float StartOffset
	{
		[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
		[Token(Token = "0x600014C")]
		 get { } //Length: 6
		[Address(RVA = "0x2E5F2F0", Offset = "0x2E5E6F0", Length = "0xA5")]
		[Token(Token = "0x600014D")]
		 set { } //Length: 165
	}

	[Token(Token = "0x1700004C")]
	internal float StartOffsetT
	{
		[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
		[Token(Token = "0x600014E")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x2E5E970", Offset = "0x2E5DD70", Length = "0x62")]
	[Token(Token = "0x6000170")]
	private static SplineAnimate() { }

	[Address(RVA = "0x2E5E9E0", Offset = "0x2E5DDE0", Length = "0x3C")]
	[Token(Token = "0x600016F")]
	public SplineAnimate() { }

	[Address(RVA = "0x2E5EA20", Offset = "0x2E5DE20", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6000155")]
	public void add_Completed(Action value) { }

	[Address(RVA = "0x2E5EB90", Offset = "0x2E5DF90", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000151")]
	public void add_onUpdated(Action<Vector3, Quaternion> value) { }

	[Address(RVA = "0x2E5EAD0", Offset = "0x2E5DED0", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x6000153")]
	public void add_Updated(Action<Vector3, Quaternion> value) { }

	[Address(RVA = "0x2E5D180", Offset = "0x2E5C580", Length = "0xB")]
	[Token(Token = "0x6000157")]
	private void Awake() { }

	[Address(RVA = "0x2E5D190", Offset = "0x2E5C590", Length = "0xE6")]
	[Token(Token = "0x6000166")]
	private void CalculateDuration() { }

	[Address(RVA = "0x2E5D280", Offset = "0x2E5C680", Length = "0xE6")]
	[Token(Token = "0x6000167")]
	private void CalculateMaxSpeed() { }

	[Address(RVA = "0x2E5D370", Offset = "0x2E5C770", Length = "0x26D")]
	[Token(Token = "0x6000161")]
	private void CalculateNormalizedTime(float deltaTime) { }

	[Address(RVA = "0x2E5D5E0", Offset = "0x2E5C9E0", Length = "0x2C")]
	[Token(Token = "0x600016E")]
	private float EaseInOutQuadratic(float t) { }

	[Address(RVA = "0x1D01A30", Offset = "0x1D00E30", Length = "0x8")]
	[Token(Token = "0x600016C")]
	private float EaseInQuadratic(float t) { }

	[Address(RVA = "0x2E5D610", Offset = "0x2E5CA10", Length = "0x11")]
	[Token(Token = "0x600016D")]
	private float EaseOutQuadratic(float t) { }

	[Address(RVA = "0x2E5D630", Offset = "0x2E5CA30", Length = "0x8C5")]
	[Token(Token = "0x6000165")]
	private void EvaluatePositionAndRotation(out Vector3 position, out Quaternion rotation) { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x600013E")]
	public AlignmentMode get_Alignment() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x600013D")]
	public AlignmentMode get_alignmentMode() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000132")]
	public Method get_AnimationMethod() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000129")]
	public SplineContainer get_Container() { }

	[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
	[Token(Token = "0x6000134")]
	public float get_duration() { }

	[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
	[Token(Token = "0x6000135")]
	public float get_Duration() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[Token(Token = "0x600013B")]
	public EasingMode get_Easing() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[Token(Token = "0x600013A")]
	public EasingMode get_easingMode() { }

	[Address(RVA = "0x16D0800", Offset = "0x16CFC00", Length = "0x6")]
	[Token(Token = "0x6000149")]
	public float get_elapsedTime() { }

	[Address(RVA = "0x16D0800", Offset = "0x16CFC00", Length = "0x6")]
	[Token(Token = "0x600014A")]
	public float get_ElapsedTime() { }

	[Address(RVA = "0x29B71F0", Offset = "0x29B65F0", Length = "0x5")]
	[Token(Token = "0x600014F")]
	public bool get_isPlaying() { }

	[Address(RVA = "0x29B71F0", Offset = "0x29B65F0", Length = "0x5")]
	[Token(Token = "0x6000150")]
	public bool get_IsPlaying() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x600012F")]
	public LoopMode get_Loop() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x600012E")]
	public LoopMode get_loopMode() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x6000137")]
	public float get_maxSpeed() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x6000138")]
	public float get_MaxSpeed() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000131")]
	public Method get_method() { }

	[Address(RVA = "0x16D0A10", Offset = "0x16CFE10", Length = "0x6")]
	[Token(Token = "0x6000146")]
	public float get_normalizedTime() { }

	[Address(RVA = "0x16D0A10", Offset = "0x16CFE10", Length = "0x6")]
	[Token(Token = "0x6000147")]
	public float get_NormalizedTime() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x6000140")]
	public AlignAxis get_objectForwardAxis() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x6000141")]
	public AlignAxis get_ObjectForwardAxis() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x6000143")]
	public AlignAxis get_objectUpAxis() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x6000144")]
	public AlignAxis get_ObjectUpAxis() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x600012B")]
	public bool get_playOnAwake() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x600012C")]
	public bool get_PlayOnAwake() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000128")]
	public SplineContainer get_splineContainer() { }

	[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
	[Token(Token = "0x600014C")]
	public float get_StartOffset() { }

	[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
	[Token(Token = "0x600014E")]
	internal float get_StartOffsetT() { }

	[Address(RVA = "0x2E5DF00", Offset = "0x2E5D300", Length = "0x88")]
	[Token(Token = "0x600016B")]
	internal float GetLoopInterpolation(bool offset) { }

	[Address(RVA = "0x2E5DF90", Offset = "0x2E5D390", Length = "0x140")]
	[Token(Token = "0x600015C")]
	private bool IsNullOrEmptyContainer() { }

	[Address(RVA = "0x2E5E0E0", Offset = "0x2E5D4E0", Length = "0x6D")]
	[Token(Token = "0x6000159")]
	private void OnDisable() { }

	[Address(RVA = "0x2E5E150", Offset = "0x2E5D550", Length = "0x91")]
	[Token(Token = "0x6000158")]
	private void OnEnable() { }

	[Address(RVA = "0x2E5E1F0", Offset = "0x2E5D5F0", Length = "0x7")]
	[Token(Token = "0x600016A")]
	private void OnSplineChange(Spline spline, int knotIndex, SplineModification modificationType) { }

	[Address(RVA = "0x2E5E200", Offset = "0x2E5D600", Length = "0x23")]
	[Token(Token = "0x600015A")]
	private void OnValidate() { }

	[Address(RVA = "0x2E5E230", Offset = "0x2E5D630", Length = "0x5")]
	[Token(Token = "0x600015E")]
	public void Pause() { }

	[Address(RVA = "0x2E5E240", Offset = "0x2E5D640", Length = "0x1E")]
	[Token(Token = "0x600015D")]
	public void Play() { }

	[Address(RVA = "0x2E5E260", Offset = "0x2E5D660", Length = "0x104")]
	[Token(Token = "0x6000168")]
	private void RebuildSplinePath() { }

	[Address(RVA = "0x2E5E370", Offset = "0x2E5D770", Length = "0xCE")]
	[Token(Token = "0x600015B")]
	internal void RecalculateAnimationParameters() { }

	[Address(RVA = "0x2E5EC40", Offset = "0x2E5E040", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6000156")]
	public void remove_Completed(Action value) { }

	[Address(RVA = "0x2E5EDB0", Offset = "0x2E5E1B0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000152")]
	public void remove_onUpdated(Action<Vector3, Quaternion> value) { }

	[Address(RVA = "0x2E5ECF0", Offset = "0x2E5E0F0", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x6000154")]
	public void remove_Updated(Action<Vector3, Quaternion> value) { }

	[Address(RVA = "0x2E5E440", Offset = "0x2E5D840", Length = "0x1A4")]
	[Token(Token = "0x600015F")]
	public void Restart(bool autoplay) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[Token(Token = "0x600013F")]
	public void set_Alignment(AlignmentMode value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x6000133")]
	public void set_AnimationMethod(Method value) { }

	[Address(RVA = "0x2E5EE60", Offset = "0x2E5E260", Length = "0x2FB")]
	[Token(Token = "0x600012A")]
	public void set_Container(SplineContainer value) { }

	[Address(RVA = "0x2E5F160", Offset = "0x2E5E560", Length = "0x1A")]
	[Token(Token = "0x6000136")]
	public void set_Duration(float value) { }

	[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
	[Token(Token = "0x600013C")]
	public void set_Easing(EasingMode value) { }

	[Address(RVA = "0x2E5F180", Offset = "0x2E5E580", Length = "0x28")]
	[Token(Token = "0x600014B")]
	public void set_ElapsedTime(float value) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[Token(Token = "0x6000130")]
	public void set_Loop(LoopMode value) { }

	[Address(RVA = "0x2E5F1B0", Offset = "0x2E5E5B0", Length = "0x1A")]
	[Token(Token = "0x6000139")]
	public void set_MaxSpeed(float value) { }

	[Address(RVA = "0x2E5F1D0", Offset = "0x2E5E5D0", Length = "0x5C")]
	[Token(Token = "0x6000148")]
	public void set_NormalizedTime(float value) { }

	[Address(RVA = "0x2E5F230", Offset = "0x2E5E630", Length = "0x5A")]
	[Token(Token = "0x6000142")]
	public void set_ObjectForwardAxis(AlignAxis value) { }

	[Address(RVA = "0x2E5F290", Offset = "0x2E5E690", Length = "0x5A")]
	[Token(Token = "0x6000145")]
	public void set_ObjectUpAxis(AlignAxis value) { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[Token(Token = "0x600012D")]
	public void set_PlayOnAwake(bool value) { }

	[Address(RVA = "0x2E5F2F0", Offset = "0x2E5E6F0", Length = "0xA5")]
	[Token(Token = "0x600014D")]
	public void set_StartOffset(float value) { }

	[Address(RVA = "0x2E5E5F0", Offset = "0x2E5D9F0", Length = "0x4D")]
	[Token(Token = "0x6000169")]
	private AlignAxis SetObjectAlignAxis(AlignAxis newValue, ref AlignAxis targetAxis, AlignAxis otherAxis) { }

	[Address(RVA = "0x2E5E920", Offset = "0x2E5DD20", Length = "0x4D")]
	[Token(Token = "0x6000160")]
	public void Update() { }

	[Address(RVA = "0x2E5E640", Offset = "0x2E5DA40", Length = "0xD7")]
	[Token(Token = "0x6000162")]
	private void UpdateEndReached(float previousTime, float currentDuration) { }

	[Address(RVA = "0x2E5E720", Offset = "0x2E5DB20", Length = "0x5F")]
	[Token(Token = "0x6000163")]
	private void UpdateStartOffsetT() { }

	[Address(RVA = "0x2E5E780", Offset = "0x2E5DB80", Length = "0x19F")]
	[Token(Token = "0x6000164")]
	private void UpdateTransform() { }

}

