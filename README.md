# UniSlide
Unityで作ったものをプレゼンするときプレゼンソフトとUnityを行き来するのめんどくさくないですか？<br>
じゃあUnityでプレゼンすれば解決ですね(狂気)<br>
Unityでプレゼン資料が作りやすくなるようなエディタ拡張を作りました。
## 環境
Unity2019.3.1f1
## 使い方
### スライドの作成
1. プロジェクトを開き適当にシーンを作る(もともとのシーンでも可)
2. メニューバーのWindow/Presentation/CreateSlideを選択
3. CreateSlideウインドウのSlideTypeから使いたいスライドを選択しCreateNewSlideをクリック(プレビューが下の方に表示されます)
4. 作られたスライドはシーン上のPresentationManager/Slides以下に入ります。
5. それぞれのスライドを選択しインスペクタで編集を行ってください。
    - 画像などを追加する場合は各々のCanvas以下に配置しサイズ調整などを行ってください。
### プレゼンを行う(Editモードで)
1. Window/Presentation/CreateSlideを選択(スライド作成の段階でコントローラは表示
されるので省略可)
2. ControllerウインドウのPrevボタンで一つ前のスライドに、Nextボタンで一つ次のスライドになります。
3. ChangeCameraボタンはスライド用カメラとMainCameraを切り替えます。
### プレゼンを行う(Playモードで)
1. Playモードにする
2. 矢印右で次のスライドへ、左で前のスライドへ
3. "C"キーでカメラを切り替えます。

## バグ報告
[@guchimoriVR82](https://twitter.com/guchimoriVR82)<br>
こちらにDMを送りつけてください
