// Serialized-layout reconstruction only. Original methods/inheritance were stripped from metadata.
// Public fields reproduce original type-tree order. Array-vs-List and flattened base layout are explicit approximations.
using UnityEngine;
namespace Samples {
 public class SampleScene : MonoBehaviour {
  public KANAI.Kernel.PrefabPacks _residentBulletPacks;
  public KANAI.Kernel.PrefabPacks _residentEffectPacks;
  public ShaderVariantCollection _shaderVariantCollection;
 }
 public class MarkerBase : MonoBehaviour {
  public KANAI.HybridCollision.HybridCollisionModel[] _collisions;
  public float _HitPoint;
  public bool _isLockonTarget;
  public bool _isLaserBlock;
  public TMPro.TextMeshPro _tmpro;
  public MeshRenderer _cube;
  public Material[] _material;
 }
}
