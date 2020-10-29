# PlayableTimelineTest


## 目的
Playable Trackの理解


## Playable Trackとは？
アニメーションや音源の再生時間を管理するTimeLine上に、スクリプト制御を設定できるTrack
<br>下記の動画ではPlayable Trackを用いて、スライドの切り替えを行っている
<br>※同時にアニメーションTrackで球のサイズを大小している

[![Playing Slide TimeLine](http://img.youtube.com/vi/Si_4G2xJgKY/0.jpg)](http://www.youtube.com/watch?v=Si_4G2xJgKY "Playing Slide TimeLine")

## 設定方法
1. PlayableBehaviourクラスを継承したクラスで、振る舞いを設定
```
```


2. PlayableAssetクラスを継承したクラスで、振る舞いをTrack上に差し込めるAssetを作成
```
```

3. UnityのGUIでTimelineのPlayable Track上にPlayable Assetを挿入(右クリックで勝手に出てくる)
