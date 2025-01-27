// Copyright (c) Stride contributors (https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Reflection;
using Stride.Core;
using Stride.Core.Reflection;

namespace Stride.Engine
{
    internal class Module
    {
        [ModuleInitializer]
        public static void Initialize()
        {
            AssemblyRegistry.Register(typeof(Module).GetTypeInfo().Assembly, AssemblyCommonCategories.Assets);

            // Preload proper libbulletc native library (depending on CPU type)
            NativeLibraryHelper.PreloadLibrary("libbulletc.dll", typeof(PhysicsComponent));
        }
    }
}
