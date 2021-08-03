public class UserApplicationService {
    // AOPを使ったパターン
    @Transactional
    public void Register(UserRegisterCommand command) {
        // ユーザー生成処理、重複チェック、
        // UserRepositoryを使ってDBへの保存処理のコード
        // コード本体を書かなくてもメソッド正常終了でコミット、
        // 途中の例外でロールバックを自動でやってくれる
    }
}