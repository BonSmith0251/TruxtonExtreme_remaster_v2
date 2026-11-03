namespace Unity.Cinemachine;

[Token(Token = "0x20000BC")]
public interface ICinemachineCamera
{
	[Token(Token = "0x20000BE")]
	internal class ActivationEvent : UnityEvent<ActivationEventParams>
	{

		[Address(RVA = "0x2833840", Offset = "0x2832C40", Length = "0x39")]
		[Token(Token = "0x60003B3")]
		public ActivationEvent() { }

	}

	[Token(Token = "0x20000BD")]
	internal struct ActivationEventParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E1")]
		public ICinemachineMixer Origin; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002E2")]
		public ICinemachineCamera OutgoingCamera; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002E3")]
		public ICinemachineCamera IncomingCamera; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002E4")]
		public bool IsCut; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40002E5")]
		public Vector3 WorldUp; //Field offset: 0x1C
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002E6")]
		public float DeltaTime; //Field offset: 0x28

	}


	[Token(Token = "0x170000CD")]
	public string Description
	{
		[Token(Token = "0x60003AD")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000CF")]
	public bool IsValid
	{
		[Token(Token = "0x60003AF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000CC")]
	public string Name
	{
		[Token(Token = "0x60003AC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000D0")]
	public ICinemachineMixer ParentCamera
	{
		[Token(Token = "0x60003B0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000CE")]
	public CameraState State
	{
		[Token(Token = "0x60003AE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60003AD")]
	public string get_Description() { }

	[Token(Token = "0x60003AF")]
	public bool get_IsValid() { }

	[Token(Token = "0x60003AC")]
	public string get_Name() { }

	[Token(Token = "0x60003B0")]
	public ICinemachineMixer get_ParentCamera() { }

	[Token(Token = "0x60003AE")]
	public CameraState get_State() { }

	[Token(Token = "0x60003B2")]
	public void OnCameraActivated(ActivationEventParams evt) { }

	[Token(Token = "0x60003B1")]
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

}

