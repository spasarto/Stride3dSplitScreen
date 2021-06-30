using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.Core;
using Stride.Graphics;
using Stride.Rendering;
using Stride.Rendering.Sprites;

namespace SplitScreenExample
{
    public class Screen : StartupScript {
        
        [Display("Center")]
        public Vector2 center;

        [Display("Render Target")]
        public Texture renderTexture;

        [Display("Render Group")]
        public RenderGroup renderGroup;

        private SpriteComponent surface;

        public override void Start() {

            surface = new SpriteComponent() {
                RenderGroup = renderGroup,
                SpriteProvider = new SpriteFromTexture() {
                    Texture = renderTexture,
                    IsTransparent = false,
                    Center = center
                }
            };

            Entity.Add(surface);

        }

    }
}
