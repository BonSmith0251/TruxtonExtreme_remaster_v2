namespace Unity.Cinemachine;

[Token(Token = "0x20000D2")]
public struct LensSettings
{
	[Token(Token = "0x20000D3")]
	internal enum OverrideModes : int
	{
		None = 0,
		Orthographic = 1,
		Perspective = 2,
		Physical = 3,
	}

	[Token(Token = "0x20000D4")]
	[Tooltip("These are settings that are used only if IsPhysicalCamera is true")]
	internal struct PhysicalSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000322")]
		[Tooltip("How the image is fitted to the sensor if the aspect ratios differ")]
		public GateFitMode GateFit; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[SensorSizeProperty]
		[Token(Token = "0x4000323")]
		[Tooltip("This is the actual size of the image sensor (in mm)")]
		public Vector2 SensorSize; //Field offset: 0x4
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000324")]
		[Tooltip("Position of the gate relative to the film back")]
		public Vector2 LensShift; //Field offset: 0xC
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000325")]
		[Tooltip("Distance from the camera lens at which focus is sharpest.  The Depth of Field Volume override uses this value if you set FocusDistanceMode to Camera")]
		public float FocusDistance; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000326")]
		[Tooltip("The sensor sensitivity (ISO)")]
		public int Iso; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000327")]
		[Tooltip("The exposure time, in seconds")]
		public float ShutterSpeed; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Range(0.7, 32)]
		[Token(Token = "0x4000328")]
		[Tooltip("The aperture number, in f-stop")]
		public float Aperture; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Range(3, 11)]
		[Token(Token = "0x4000329")]
		[Tooltip("The number of diaphragm blades")]
		public int BladeCount; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[MinMaxRangeSlider(0.7, 32)]
		[Token(Token = "0x400032A")]
		[Tooltip("Maps an aperture range to blade curvature")]
		public Vector2 Curvature; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Range(0, 1)]
		[Token(Token = "0x400032B")]
		[Tooltip("The strength of the \"cat-eye\" effect on bokeh (optical vignetting)")]
		public float BarrelClipping; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Range(-1, 1)]
		[Token(Token = "0x400032C")]
		[Tooltip("Stretches the sensor to simulate an anamorphic look.  Positive values distort the camera vertically, negative values distort the camera horizontally")]
		public float Anamorphism; //Field offset: 0x34

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000313")]
	[Tooltip("This setting controls the Field of View or Local Length of the lens, depending on whether the camera mode is physical or nonphysical.  Field of View can be either horizontal or vertical, depending on the setting in the Camera component.")]
	public float FieldOfView; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000314")]
	[Tooltip("When using an orthographic camera, this defines the half-height, in world coordinates, of the camera view.")]
	public float OrthographicSize; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000315")]
	[Tooltip("This defines the near region in the renderable range of the camera frustum. Raising this value will stop the game from drawing things near the camera, which can sometimes come in handy.  Larger values will also increase your shadow resolution.")]
	public float NearClipPlane; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000316")]
	[Tooltip("This defines the far region of the renderable range of the camera frustum. Typically you want to set this value as low as possible without cutting off desired distant objects")]
	public float FarClipPlane; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000317")]
	[Tooltip("Camera Z roll, or tilt, in degrees.")]
	public float Dutch; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000318")]
	[Tooltip("Allows you to select a different camera mode to apply to the Camera component when Cinemachine activates this Virtual Camera.")]
	public OverrideModes ModeOverride; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000319")]
	public PhysicalSettings PhysicalProperties; //Field offset: 0x18
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400031A")]
	private bool m_OrthoFromCamera; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x400031B")]
	private bool m_PhysicalFromCamera; //Field offset: 0x51
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400031C")]
	private float m_AspectFromCamera; //Field offset: 0x54

	[Token(Token = "0x170000D9")]
	public float Aspect
	{
		[Address(RVA = "0x28468D0", Offset = "0x2845CD0", Length = "0x23")]
		[Token(Token = "0x60003ED")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170000DA")]
	public static LensSettings Default
	{
		[Address(RVA = "0x2846900", Offset = "0x2845D00", Length = "0x100")]
		[Token(Token = "0x60003EE")]
		 get { } //Length: 256
	}

	[Token(Token = "0x170000D8")]
	public bool IsPhysicalCamera
	{
		[Address(RVA = "0x2846A00", Offset = "0x2845E00", Length = "0x17")]
		[Token(Token = "0x60003EC")]
		 get { } //Length: 23
	}

	[Token(Token = "0x170000D7")]
	public bool Orthographic
	{
		[Address(RVA = "0x2846A20", Offset = "0x2845E20", Length = "0x17")]
		[Token(Token = "0x60003EB")]
		 get { } //Length: 23
	}

	[Address(RVA = "0x2845D60", Offset = "0x2845160", Length = "0x1DD")]
	[Token(Token = "0x60003F5")]
	public static bool AreEqual(ref LensSettings a, ref LensSettings b) { }

	[Address(RVA = "0x2845F40", Offset = "0x2845340", Length = "0x57")]
	[Token(Token = "0x60003F1")]
	public void CopyCameraMode(ref LensSettings fromLens) { }

	[Address(RVA = "0x2845FA0", Offset = "0x28453A0", Length = "0x2A3")]
	[Token(Token = "0x60003EF")]
	public static LensSettings FromCamera(Camera fromCamera) { }

	[Address(RVA = "0x28468D0", Offset = "0x2845CD0", Length = "0x23")]
	[Token(Token = "0x60003ED")]
	public float get_Aspect() { }

	[Address(RVA = "0x2846900", Offset = "0x2845D00", Length = "0x100")]
	[Token(Token = "0x60003EE")]
	public static LensSettings get_Default() { }

	[Address(RVA = "0x2846A00", Offset = "0x2845E00", Length = "0x17")]
	[Token(Token = "0x60003EC")]
	public bool get_IsPhysicalCamera() { }

	[Address(RVA = "0x2846A20", Offset = "0x2845E20", Length = "0x17")]
	[Token(Token = "0x60003EB")]
	public bool get_Orthographic() { }

	[Address(RVA = "0x2846600", Offset = "0x2845A00", Length = "0xF9")]
	[Token(Token = "0x60003F2")]
	public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t) { }

	[Address(RVA = "0x2846250", Offset = "0x2845650", Length = "0x3A9")]
	[Token(Token = "0x60003F3")]
	public void Lerp(in LensSettings lensB, float t) { }

	[Address(RVA = "0x2846700", Offset = "0x2845B00", Length = "0x54")]
	[Token(Token = "0x60003F0")]
	public void PullInheritedPropertiesFromCamera(Camera camera) { }

	[Address(RVA = "0x2846760", Offset = "0x2845B60", Length = "0x16C")]
	[Token(Token = "0x60003F4")]
	public void Validate() { }

}

