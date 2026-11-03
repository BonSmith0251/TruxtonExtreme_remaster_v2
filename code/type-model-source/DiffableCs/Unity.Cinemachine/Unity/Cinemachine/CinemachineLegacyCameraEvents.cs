namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[Obsolete("Please use CinemachineCameraEvents instead.")]
[Token(Token = "0x2000120")]
public class CinemachineLegacyCameraEvents : MonoBehaviour
{
	[Token(Token = "0x2000121")]
	internal class OnCameraLiveEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera>
	{

		[Address(RVA = "0x287F180", Offset = "0x287E580", Length = "0x39")]
		[Token(Token = "0x6000587")]
		public OnCameraLiveEvent() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004AF")]
	[Tooltip("This event fires when the CinemachineCamera goes Live")]
	public OnCameraLiveEvent OnCameraLive; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004B0")]
	private CinemachineVirtualCameraBase m_Vcam; //Field offset: 0x28

	[Address(RVA = "0x286FC00", Offset = "0x286F000", Length = "0x87")]
	[Token(Token = "0x6000586")]
	public CinemachineLegacyCameraEvents() { }

	[Address(RVA = "0x286F980", Offset = "0x286ED80", Length = "0x72")]
	[Token(Token = "0x6000585")]
	private void OnCameraActivated(ActivationEventParams evt) { }

	[Address(RVA = "0x286FA00", Offset = "0x286EE00", Length = "0xCB")]
	[Token(Token = "0x6000584")]
	private void OnDisable() { }

	[Address(RVA = "0x286FAD0", Offset = "0x286EED0", Length = "0x121")]
	[Token(Token = "0x6000583")]
	private void OnEnable() { }

}

