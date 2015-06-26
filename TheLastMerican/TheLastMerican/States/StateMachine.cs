using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheLastMerican.States
{
    class StateMachine
    {
        private BaseState[]     mStates;
        private int             mCurrentState;
        private ContentManager  mContent;

        public StateMachine( ContentManager content )
        {
            mContent    = content;

            mStates     = new BaseState[GameStateType.NumberOfStates];

            //---------- Create all GameStates here --------------
            mStates[GameStateType.PLAY_STATE]        = new PlayState( content );
            //----------------------------------------------------
        }

        public void Update( GameTime gameTime )
        {
            mStates[mCurrentState].Update( gameTime );
        }

        public void Draw( SpriteBatch spriteBatch )
        {
            mStates[mCurrentState].Draw( spriteBatch );
        }

        public void ChangeState( int NEW_STATE )
        {
            mStates[mCurrentState].OnExit();
            mCurrentState = NEW_STATE;
            mStates[mCurrentState].OnEnter();
        }

        public void ResetState( int STATE )
        {
            mStates[STATE].Reset();
        }
    }
}
