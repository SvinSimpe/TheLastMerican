using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheLastMerican.States
{
    static public class GameStateType
    {
        static public int NumberOfStates    = 1;

        // ----------- Add new states here -------------
        static public int PLAY_STATE                = 0;
        // ---------------------------------------------
    }

    abstract class BaseState
    {
        protected ContentManager    mContent;
        protected int               mStateType;

        public int StateType
        {
            get { return mStateType; }
            set { mStateType = value; }
        }

        public BaseState(ContentManager content)
        {
            mContent    = content;
        }

        virtual public void Update( GameTime gameTime )
        {}

        virtual public void Draw( SpriteBatch spriteBatch )
        {}

        virtual public void OnEnter()
        {}

        virtual public void OnExit()
        {}

        virtual public void Reset()
        {}
    }
}
