using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SlideAsset : PlayableAsset
{
    public Sprite image;

    public override Playable CreatePlayable( PlayableGraph graph, GameObject owner ) {
        //PlayableBehaviourを継承したSlideChangeクラスを元に、PlayableAsset(コマ)を作る
        var player = ScriptPlayable<SlideChange>.Create( graph );
        
        //SlideChangeクラスにあるプロパティを設定
        var behaviour = player.GetBehaviour();
        behaviour.slideImage = image;
        
        return player;
    }
}
