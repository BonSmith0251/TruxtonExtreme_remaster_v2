# Prefab organisation conventions

## Folder structure

Type-first under `Assets/Prefabs`, one folder per kind of thing the game spawns or places:

```
Assets/Prefabs/
  Player/          the player and its pieces       Player/Parts/   turrets, option pods, only used inside Player
  Enemies/         regular enemies, enemy objects   Enemies/Parts/
  Bosses/
  Projectiles/     bullets, lasers, missiles (player and enemy)
  Effects/         particles, explosions, muzzle flashes, trails
  Pickups/         items, power-ups, coins
  Characters/      NPCs
  Environment/     props, terrain pieces, stage dressing
  Lighting/  Cameras/  Audio/
  UI/              Canvas-rooted prefabs, HUD, menus, popups
  Systems/         managers, spawners, pools, directors
  Misc/            nothing matched - review these by hand
```

Feature-first (`Assets/Features/Enemies/Grunt/{Grunt.prefab, Grunt.mat, Grunt.anim}`) suits large teams that own features; it is a bigger move (materials, meshes and animations go with the prefab) and is better planned by hand with unity-project-layout. Offer it only when the user asks for it.

Rules of thumb:
- **Variants live with their base.** A variant is "the base, changed"; finding it next to the base is what people expect. A `Variants/` sub-folder only when a base has many.
- **Parts go under their owner.** A prefab used only inside other prefabs (never placed in a scene, never spawned by data) is a part; `<Owner category>/Parts` keeps the top-level folders to things people actually place or spawn.
- **Unused is not deletable.** A prefab no scene, prefab or asset references may still be spawned by code by name or path (check the survey's name references) or kept for reference. Report, don't delete, unless the user asks.
- **Do not move:** prefabs inside `Resources` (loaded by path inside Resources), inside `Editor` folders, Addressables entries whose address is their path if code builds that address, third-party packages, and folders a tool generated and tracks with its own manifest (move those only with the tool's manifest updated - rewrite_paths.py does that if the manifest stores asset paths).

## Naming

Common conventions: PascalCase names (`EnemyGrunt`, `BulletLaser`), optional type prefix (`PF_`, `P_` or none - Unity shows the type icon anyway), variants named `<Base>_<Variant>` or `<Base> Variant` (Unity's default), no spaces or trailing copies (`Rock (1)`, `rock__2`). Pick one and apply it to new prefabs; renaming existing ones is a separate decision:

- **Renaming breaks name lookups.** `AssetDatabase.FindAssets(name)`, `Resources.Load("Folder/Name")`, data tables that store model or prefab names, Addressables addresses, animation events and string-based spawn systems all use the name. GUID references (scenes, prefabs, inspector fields) survive renames.
- The survey counts quoted-string mentions of each name in code and data. The planner refuses to rename those. A name that is also an ordinary word or key (a stage called `BG03`, a prefab called `Light`) can be a false match; confirm with the user rather than overriding blindly.
- Imported or ripped content often keeps the original names on purpose (they match the original game's data); leave it.

## Classification signals

| Signal | Reliable for |
| --- | --- |
| Root is RectTransform / has Canvas | UI |
| Name patterns (prefixes, keywords) | most game categories; projects are usually consistent within themselves, so learn their prefixes first |
| ParticleSystem / VisualEffect / Trail / Line renderers | Effects (once name rules for projectiles and pickups have had their chance: bullets often carry particles) |
| Only a Light (plus pipeline light data) | Lighting |
| Camera | Cameras |
| Only an AudioSource | Audio |
| Renderers only | Environment props, as a last resort |
| Used only inside other prefabs | Parts |
| Is a variant | its base's category |

Order matters: put the project's own prefix rules first, specific keywords (bullet, item, boss) before broad ones (enemy prefixes), component fallbacks last.
