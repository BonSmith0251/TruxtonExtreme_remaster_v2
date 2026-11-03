namespace UnityEngine.Rendering;

[Obsolete("This is not longer supported Please use DebugDisplaySettingsVolume. #from(6000.2)")]
[Token(Token = "0x20000D4")]
public interface IVolumeDebugSettings
{

	[Token(Token = "0x170000B4")]
	public IEnumerable<Camera> cameras
	{
		[Token(Token = "0x6000797")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B3")]
	public Camera selectedCamera
	{
		[Token(Token = "0x6000796")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B5")]
	public int selectedCameraIndex
	{
		[Token(Token = "0x6000798")]
		 get { } //Length: 0
		[Token(Token = "0x6000799")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170000B7")]
	public LayerMask selectedCameraLayerMask
	{
		[Token(Token = "0x600079B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B8")]
	public Vector3 selectedCameraPosition
	{
		[Token(Token = "0x600079C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B6")]
	public VolumeStack selectedCameraVolumeStack
	{
		[Token(Token = "0x600079A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B2")]
	public int selectedComponent
	{
		[Token(Token = "0x6000794")]
		 get { } //Length: 0
		[Token(Token = "0x6000795")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170000B9")]
	public Type selectedComponentType
	{
		[Token(Token = "0x600079D")]
		 get { } //Length: 0
		[Token(Token = "0x600079E")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000797")]
	public IEnumerable<Camera> get_cameras() { }

	[Token(Token = "0x6000796")]
	public Camera get_selectedCamera() { }

	[Token(Token = "0x6000798")]
	public int get_selectedCameraIndex() { }

	[Token(Token = "0x600079B")]
	public LayerMask get_selectedCameraLayerMask() { }

	[Token(Token = "0x600079C")]
	public Vector3 get_selectedCameraPosition() { }

	[Token(Token = "0x600079A")]
	public VolumeStack get_selectedCameraVolumeStack() { }

	[Token(Token = "0x6000794")]
	public int get_selectedComponent() { }

	[Token(Token = "0x600079D")]
	public Type get_selectedComponentType() { }

	[Token(Token = "0x600079F")]
	public Volume[] GetVolumes() { }

	[Token(Token = "0x60007A2")]
	public float GetVolumeWeight(Volume volume) { }

	[Token(Token = "0x60007A1")]
	public bool RefreshVolumes(Volume[] newVolumes) { }

	[Token(Token = "0x6000799")]
	public void set_selectedCameraIndex(int value) { }

	[Token(Token = "0x6000795")]
	public void set_selectedComponent(int value) { }

	[Token(Token = "0x600079E")]
	public void set_selectedComponentType(Type value) { }

	[Token(Token = "0x60007A0")]
	public bool VolumeHasInfluence(Volume volume) { }

}

