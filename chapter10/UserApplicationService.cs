public class UserApplicationService{
    // トランザクションによる防御
    public void Register(UserRegisterComamnd command)
    {
        using(var transaciton = connection.BeginTransaction())
        {
            // ユーザー生成処理、重複チェックの後に...
            UserRepository.save(user, transaction); // DBへの保存処理の引数にトランザクションを渡す
            transaction.Commit(); //ここでトランザクションをコミット
        }
    }

    // トランザクションスコープを使った場合
    public void Register(UserRegisterComamnd command)
    {
        using(var transaciton = new TransactionScope())
        {
            // UserRepositoryを使って
            // ユーザー生成処理、重複チェック...
            // DBへの保存処理をしてから...
            transaction.Complete();
        }
    }


}