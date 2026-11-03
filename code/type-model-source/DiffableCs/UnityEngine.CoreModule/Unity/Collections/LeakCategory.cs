namespace Unity.Collections;

[Token(Token = "0x2000056")]
[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.AIModule"})]
internal enum LeakCategory : int
{
	Invalid = 0,
	Malloc = 1,
	TempJob = 2,
	Persistent = 3,
	LightProbesQuery = 4,
	NativeTest = 5,
	MeshDataArray = 6,
	TransformAccessArray = 7,
	NavMeshQuery = 8,
}

