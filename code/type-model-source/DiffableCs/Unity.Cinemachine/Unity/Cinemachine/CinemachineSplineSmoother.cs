namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Helpers/Cinemachine Spline Smoother")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineSplineSmoother.html")]
[RequireComponent(typeof(SplineContainer))]
[Token(Token = "0x2000148")]
public class CinemachineSplineSmoother : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000563")]
	[Tooltip("If checked, the spline will be automatically smoothed whenever it is modified (editor only).")]
	public bool AutoSmooth; //Field offset: 0x20

	[Address(RVA = "0x5D5A40", Offset = "0x5D4E40", Length = "0xB")]
	[Token(Token = "0x600066C")]
	public CinemachineSplineSmoother() { }

	[Address(RVA = "0x2877C20", Offset = "0x2877020", Length = "0x602")]
	[Token(Token = "0x600066B")]
	public void SmoothSplineNow() { }

}

