using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SlideChange : PlayableBehaviour
{
    public Sprite slideImage;
    public GameObject spriteObject;

    //タイムライン開始時実行される
    public override void OnGraphStart( Playable playable ) {
        base.OnGraphStart( playable );
        
        //スライドを表示するGameObjectを取得
        spriteObject = GameObject.FindGameObjectWithTag("Window");
    }

    //PlayableAsset(コマ)再生時実行される
    public override void OnBehaviourPlay( Playable playable, FrameData info ) {
        
        //スライドの画像(Sprite)を変更
        spriteObject.GetComponent<SpriteRenderer>().sprite = slideImage;
    
    }
}
