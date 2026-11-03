namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine FreeLook Modifier")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineFreeLookModifier.html")]
[SaveDuringPlay]
[Token(Token = "0x2000027")]
public class CinemachineFreeLookModifier : CinemachineExtension
{
	[Token(Token = "0x200002E")]
	internal abstract class ComponentModifier : Modifier
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AE")]
		protected T CachedComponent; //Field offset: 0x0

		[Token(Token = "0x17000022")]
		public virtual Type CachedComponentType
		{
			[Address(RVA = "0x17A5120", Offset = "0x17A4520", Length = "0x39")]
			[Token(Token = "0x60000D3")]
			 get { } //Length: 57
		}

		[Token(Token = "0x17000021")]
		public virtual bool HasRequiredComponent
		{
			[Address(RVA = "0x17A5210", Offset = "0x17A4610", Length = "0x9")]
			[Token(Token = "0x60000D2")]
			 get { } //Length: 9
		}

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60000D5")]
		protected ComponentModifier`1() { }

		[Address(RVA = "0x17A5120", Offset = "0x17A4520", Length = "0x39")]
		[Token(Token = "0x60000D3")]
		public virtual Type get_CachedComponentType() { }

		[Address(RVA = "0x17A5210", Offset = "0x17A4610", Length = "0x9")]
		[Token(Token = "0x60000D2")]
		public virtual bool get_HasRequiredComponent() { }

		[Address(RVA = "0x17A50A0", Offset = "0x17A44A0", Length = "0x1E")]
		[Token(Token = "0x60000D4")]
		public virtual void RefreshCache(CinemachineVirtualCameraBase vcam) { }

	}

	[Token(Token = "0x2000032")]
	internal class CompositionModifier : ComponentModifier<IModifiableComposition>
	{
		[FieldOffset(Offset = "0x18")]
		[HideFoldout]
		[Token(Token = "0x40000B4")]
		public TopBottomRigs<ScreenComposerSettings> Composition; //Field offset: 0x18
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40000B5")]
		private ScreenComposerSettings m_SavedComposition; //Field offset: 0x68

		[Address(RVA = "0x28160D0", Offset = "0x28154D0", Length = "0x39")]
		[Token(Token = "0x60000E7")]
		public CompositionModifier() { }

		[Address(RVA = "0x2815D90", Offset = "0x2815190", Length = "0x104")]
		[Token(Token = "0x60000E6")]
		public virtual void AfterPipeline(CinemachineVirtualCameraBase vcam, ref CameraState state, float deltaTime, float modifierValue) { }

		[Address(RVA = "0x2815EA0", Offset = "0x28152A0", Length = "0x18C")]
		[Token(Token = "0x60000E5")]
		public virtual void BeforePipeline(CinemachineVirtualCameraBase vcam, ref CameraState state, float deltaTime, float modifierValue) { }

		[Address(RVA = "0x2816030", Offset = "0x2815430", Length = "0x6F")]
		[Token(Token = "0x60000E4")]
		public virtual void Reset(CinemachineVirtualCameraBase vcam) { }

		[Address(RVA = "0x28160A0", Offset = "0x28154A0", Length = "0x24")]
		[Token(Token = "0x60000E3")]
		public virtual void Validate(CinemachineVirtualCameraBase vcam) { }

	}

	[Token(Token = "0x2000033")]
	internal class DistanceModifier : ComponentModifier<IModifiableDistance>
	{
		[FieldOffset(Offset = "0x18")]
		[HideFoldout]
		[Token(Token = "0x40000B6")]
		public TopBottomRigs<Single> Distance; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B7")]
		private float m_CenterDistance; //Field offset: 0x20

		[Address(RVA = "0x28163E0", Offset = "0x28157E0", Length = "0x39")]
		[Token(Token = "0x60000EC")]
		public DistanceModifier() { }

		[Address(RVA = "0x2816220", Offset = "0x2815620", Length = "0x51")]
		[Token(Token = "0x60000EB")]
		public virtual void AfterPipeline(CinemachineVirtualCameraBase vcam, ref CameraState state, float deltaTime, float modifierValue) { }

		[Address(RVA = "0x2816280", Offset = "0x2815680", Length = "0xED")]
		[Token(Token = "0x60000EA")]
		public virtual void BeforePipeline(CinemachineVirtualCameraBase vcam, ref CameraState state, float deltaTime, float modifierValue) { }

		[Address(RVA = "0x2816370", Offset = "0x2815770", Length = "0x4E")]
		[Token(Token = "0x60000E9")]
		public virtual void Reset(CinemachineVirtualCameraBase vcam) { }

		[Address(RVA = "0x28163C0", Offset = "0x28157C0", Length = "0x1D")]
		[Token(Token = "0x60000E8")]
		public virtual void Validate(CinemachineVirtualCameraBase vcam) { }

	}

	[Token(Token = "0x200002A")]
	internal interface IModifiableComposition
	{

		[Token(Token = "0x1700001C")]
		public ScreenComposerSettings Composition
		{
			[Token(Token = "0x60000C4")]
			 get { } //Length: 0
			[Token(Token = "0x60000C5")]
			 set { } //Length: 0
		}

		[Token(Token = "0x60000C4")]
		public ScreenComposerSettings get_Composition() { }

		[Token(Token = "0x60000C5")]
		public void set_Composition(ScreenComposerSettings value) { }

	}

	[Token(Token = "0x200002B")]
	internal interface IModifiableDistance
	{

		[Token(Token = "0x1700001D")]
		public float Distance
		{
			[Token(Token = "0x60000C6")]
			 get { } //Length: 0
			[Token(Token = "0x60000C7")]
			 set { } //Length: 0
		}

		[Token(Token = "0x60000C6")]
		public float get_Distance() { }

		[Token(Token = "0x60000C7")]
		public void set_Distance(float value) { }

	}

	[Token(Token = "0x200002C")]
	internal interface IModifiableNoise
	{

		[Token(Token = "0x1700001E")]
		public ValueTuple<Single, Single> NoiseAmplitudeFrequency
		{
			[Token(Token = "0x60000C8")]
			 get { } //Length: 0
			[Token(Token = "0x60000C9")]
			 set { } //Length: 0
		}

		[Token(Token = "0x60000C8")]
		public ValueTuple<Single, Single> get_NoiseAmplitudeFrequency() { }

		[Token(Token = "0x60000C9")]
		public void set_NoiseAmplitudeFrequency(ValueTuple<Single, Single> value) { }

	}

	[Token(Token = "0x2000029")]
	internal interface IModifiablePositionDamping
	{

		[Token(Token = "0x1700001B")]
		public Vector3 PositionDamping
		{
			[Token(Token = "0x60000C2")]
			 get { } //Length: 0
			[Token(Token = "0x60000C3")]
			 set { } //Length: 0
		}

		[Token(Token = "0x60000C2")]
		public Vector3 get_PositionDamping() { }

		[Token(Token = "0x60000C3")]
		public void set_PositionDamping(Vector3 value) { }

	}

	[Token(Token = "0x2000028")]
	internal interface IModifierValueSource
	{

		[Token(Token = "0x1700001A")]
		public float NormalizedModifierValue
		{
			[Token(Token = "0x60000C1")]
			 get { } //Length: 0
		}

		[Token(Token = "0x60000C1")]
		public float get_NormalizedModifierValue() { }

	}

	[Token(Token = "0x2000030")]
	internal class LensModifier : Modifier
	{
		[FieldOffset(Offset = "0x10")]
		[LensSettingsHideModeOverrideProperty]
		[Token(Token = "0x40000B0")]
		[Tooltip("Value to take at the top of the axis range")]
		public LensSettings Top; //Field offset: 0x10
		[FieldOffset(Offset = "0x68")]
		[LensSettingsHideModeOverrideProperty]
		[Token(Token = "0x40000B1")]
		[Tooltip("Value to take at the bottom of the axis range")]
		public LensSettings Bottom; //Field offset: 0x68

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000DD")]
		public LensModifier() { }

		[Address(RVA = "0x2816440", Offset = "0x2815840", Length = "0x75")]
		[Token(Token = "0x60000DC")]
		public virtual void BeforePipeline(CinemachineVirtualCameraBase vcam, ref CameraState state, float deltaTime, float modifierValue) { }

		[Address(RVA = "0x28164C0", Offset = "0x28158C0", Length = "0x2CB")]
		[Token(Token = "0x60000DB")]
		public virtual void Reset(CinemachineVirtualCameraBase vcam) { }

		[Address(RVA = "0x2816790", Offset = "0x2815B90", Length = "0x24")]
		[Token(Token = "0x60000DA")]
		public virtual void Validate(CinemachineVirtualCameraBase vcam) { }

	}

	[Token(Token = "0x200002D")]
	internal abstract class Modifier
	{

		[Token(Token = "0x1700001F")]
		public override Type CachedComponentType
		{
			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x60000CC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000020")]
		public override bool HasRequiredComponent
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x60000CD")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000D1")]
		protected Modifier() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60000D0")]
		public override void AfterPipeline(CinemachineVirtualCameraBase vcam, ref CameraState state, float deltaTime, float modifierValue) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60000CF")]
		public override void BeforePipeline(CinemachineVirtualCameraBase vcam, ref CameraState state, float deltaTime, float modifierValue) { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60000CC")]
		public override Type get_CachedComponentType() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60000CD")]
		public override bool get_HasRequiredComponent() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60000CE")]
		public override void RefreshCache(CinemachineVirtualCameraBase vcam) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60000CB")]
		public override void Reset(CinemachineVirtualCameraBase vcam) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60000CA")]
		public override void Validate(CinemachineVirtualCameraBase vcam) { }

	}

	[Token(Token = "0x2000034")]
	internal class NoiseModifier : ComponentModifier<IModifiableNoise>
	{
		[Token(Token = "0x2000035")]
		internal struct NoiseSettings
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000BA")]
			[Tooltip("Multiplier for the noise amplitude")]
			public float Amplitude; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x40000BB")]
			[Tooltip("Multiplier for the noise frequency")]
			public float Frequency; //Field offset: 0x4

		}

		[FieldOffset(Offset = "0x18")]
		[HideFoldout]
		[Token(Token = "0x40000B8")]
		public TopBottomRigs<NoiseSettings> Noise; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000B9")]
		private ValueTuple<Single, Single> m_CenterNoise; //Field offset: 0x28

		[Address(RVA = "0x2816A60", Offset = "0x2815E60", Length = "0x39")]
		[Token(Token = "0x60000F0")]
		public NoiseModifier() { }

		[Address(RVA = "0x28167C0", Offset = "0x2815BC0", Length = "0x5E")]
		[Token(Token = "0x60000EF")]
		public virtual void AfterPipeline(CinemachineVirtualCameraBase vcam, ref CameraState state, float deltaTime, float modifierValue) { }

		[Address(RVA = "0x2816820", Offset = "0x2815C20", Length = "0x1B7")]
		[Token(Token = "0x60000EE")]
		public virtual void BeforePipeline(CinemachineVirtualCameraBase vcam, ref CameraState state, float deltaTime, float modifierValue) { }

		[Address(RVA = "0x28169E0", Offset = "0x2815DE0", Length = "0x76")]
		[Token(Token = "0x60000ED")]
		public virtual void Reset(CinemachineVirtualCameraBase vcam) { }

	}

	[Token(Token = "0x2000031")]
	internal class PositionDampingModifier : ComponentModifier<IModifiablePositionDamping>
	{
		[FieldOffset(Offset = "0x18")]
		[HideFoldout]
		[Token(Token = "0x40000B2")]
		public TopBottomRigs<Vector3> Damping; //Field offset: 0x18
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000B3")]
		private Vector3 m_CenterDamping; //Field offset: 0x30

		[Address(RVA = "0x2816F10", Offset = "0x2816310", Length = "0x39")]
		[Token(Token = "0x60000E2")]
		public PositionDampingModifier() { }

		[Address(RVA = "0x2816B60", Offset = "0x2815F60", Length = "0xDE")]
		[Token(Token = "0x60000E1")]
		public virtual void AfterPipeline(CinemachineVirtualCameraBase vcam, ref CameraState state, float deltaTime, float modifierValue) { }

		[Address(RVA = "0x2816C40", Offset = "0x2816040", Length = "0x21D")]
		[Token(Token = "0x60000E0")]
		public virtual void BeforePipeline(CinemachineVirtualCameraBase vcam, ref CameraState state, float deltaTime, float modifierValue) { }

		[Address(RVA = "0x2816E60", Offset = "0x2816260", Length = "0x60")]
		[Token(Token = "0x60000DF")]
		public virtual void Reset(CinemachineVirtualCameraBase vcam) { }

		[Address(RVA = "0x2816EC0", Offset = "0x28162C0", Length = "0x4D")]
		[Token(Token = "0x60000DE")]
		public virtual void Validate(CinemachineVirtualCameraBase vcam) { }

	}

	[Token(Token = "0x200002F")]
	internal class TiltModifier : Modifier
	{
		[FieldOffset(Offset = "0x10")]
		[HideFoldout]
		[Token(Token = "0x40000AF")]
		public TopBottomRigs<Single> Tilt; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000D9")]
		public TiltModifier() { }

		[Address(RVA = "0x2817F30", Offset = "0x2817330", Length = "0x390")]
		[Token(Token = "0x60000D8")]
		public virtual void AfterPipeline(CinemachineVirtualCameraBase vcam, ref CameraState state, float deltaTime, float modifierValue) { }

		[Address(RVA = "0x28182C0", Offset = "0x28176C0", Length = "0xF")]
		[Token(Token = "0x60000D7")]
		public virtual void Reset(CinemachineVirtualCameraBase vcam) { }

		[Address(RVA = "0x28182D0", Offset = "0x28176D0", Length = "0x4D")]
		[Token(Token = "0x60000D6")]
		public virtual void Validate(CinemachineVirtualCameraBase vcam) { }

	}

	[Token(Token = "0x2000036")]
	internal struct TopBottomRigs
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BC")]
		[Tooltip("Value to take at the top of the axis range")]
		public T Top; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BD")]
		[Tooltip("Value to take at the bottom of the axis range")]
		public T Bottom; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x30")]
	[Range(0, 1)]
	[Token(Token = "0x40000A8")]
	[Tooltip("The amount of easing to apply towards the center value. Zero easing blends linearly through the center value, while an easing of 1 smooths the result as it passes over the center value.")]
	public float Easing; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeReference]
	[Token(Token = "0x40000A9")]
	[Tooltip("These will modify settings as a function of the FreeLook's Vertical axis value")]
	public List<Modifier> Modifiers; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000AA")]
	private IModifierValueSource m_ValueSource; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000AB")]
	private float m_CurrentValue; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000AC")]
	private AnimationCurve m_EasingCurve; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000AD")]
	private float m_CachedEasingValue; //Field offset: 0x58

	[Address(RVA = "0x280FCD0", Offset = "0x280F0D0", Length = "0x77")]
	[Token(Token = "0x60000C0")]
	public CinemachineFreeLookModifier() { }

	[Address(RVA = "0x280F740", Offset = "0x280EB40", Length = "0x1E")]
	[Token(Token = "0x60000BD")]
	internal bool HasValueSource() { }

	[Address(RVA = "0x280F760", Offset = "0x280EB60", Length = "0x1F")]
	[Token(Token = "0x60000BA")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x280F780", Offset = "0x280EB80", Length = "0xB3")]
	[Token(Token = "0x60000B9")]
	private void OnValidate() { }

	[Address(RVA = "0x280F840", Offset = "0x280EC40", Length = "0x127")]
	[Token(Token = "0x60000BF")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x280F970", Offset = "0x280ED70", Length = "0x273")]
	[Token(Token = "0x60000BE")]
	public virtual void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x280FBF0", Offset = "0x280EFF0", Length = "0xD2")]
	[Token(Token = "0x60000BC")]
	private void RefreshComponentCache() { }

	[Address(RVA = "0x79D230", Offset = "0x79C630", Length = "0xBC")]
	[Token(Token = "0x60000BB")]
	private static void TryGetVcamComponent(CinemachineVirtualCameraBase vcam, out T component) { }

}

