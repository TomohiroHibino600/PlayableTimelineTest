# PlayableTimelineTest


## 目的
Playable Trackの理解


## Playable Trackとは？
アニメーションや音源の再生時間を管理するTimeLine上に、スクリプト制御を設定できるTrack
<br>下記の動画ではPlayable Trackを用いて、スライドの切り替えを行っている
<br>※同時にアニメーションTrackで球のサイズを大小している

[![Playing Slide TimeLine](http://img.youtube.com/vi/Si_4G2xJgKY/0.jpg)](http://www.youtube.com/watch?v=Si_4G2xJgKY "Playing Slide TimeLine")

## Playable Trackのメリット
- 時間管理が楽
- 動画のタイミングに合わせた空間演出が可能(プレゼンや研修動画などを3Dデザインできる)
- スクリプトが分からない人に仕事を任せられる

## 設定方法
1. PlayableBehaviourクラスを継承したクラスで、振る舞いを設定
```C#:SlideChange.cs
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
```


2. PlayableAssetクラスを継承したクラスで、振る舞いをTrack上に差し込めるAssetを作成
```C#:SlideAsset.cs
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
```

```
※基本的にはPlayableAssetでコマの設定が出来、そのPropertyを設定できる。ただしMonobehaviourを継承していないので、Scene内のものを取得したい場合は
ExposedReference<ほにゃらら>
といった記述が必要になる。
```

3. UnityのGUIでTimelineのPlayable Track上にPlayable Assetを挿入(右クリックで勝手に出てくる)
![add slide asset](https://user-images.githubusercontent.com/62923803/97622618-dd331c00-1a67-11eb-97d6-e279e5ed750a.jpg)

4. Assetにプロパティがあれば、AssetをクリックしたときにInspector上で表示される場所にデータを入れておく
![add propaty](https://user-images.githubusercontent.com/62923803/97623026-6ba79d80-1a68-11eb-8238-0ce9916093d9.jpg)
