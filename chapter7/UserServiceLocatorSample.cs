public class UserServiceLocatorSample
{
    // 事前にインスタンスを登録 ここではテスト用の別リポジトリを設定
    ServiceLocator.Register<IUserRepository, InMemoryUserRepository>();

    // UserApplicationServiceクラスのコンストラクタの中のコードは変更不要！
    this.userRepository = ServiceLocator.Resolve<IUserRepository>();
}