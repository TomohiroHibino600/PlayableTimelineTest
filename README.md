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
![add slide asset](https://user-images.githubusercontent.com/62923803/97622618-dd331c00-1a67-11eb-97d6-e279e5ed750a.jpg)

4. Assetにプロパティがあれば、AssetをクリックしたときにInspector上で表示される場所にデータを入れておく
![add propaty](https://user-images.githubusercontent.com/62923803/97623026-6ba79d80-1a68-11eb-8238-0ce9916093d9.jpg)
