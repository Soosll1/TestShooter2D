using System.Collections.Generic;
using Common.Extensions;
using Entitas;

namespace Gameplay.Features.TargetCollection
{
    [Game] public class CastRange : IComponent { public float Value; }
    [Game] public class TargetsBuffer : IComponent { public List<int> Value; }
    [Game] public class LayerMask : IComponent { public int Value; }

}