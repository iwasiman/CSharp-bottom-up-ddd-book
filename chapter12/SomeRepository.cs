public class SomeRepository: IUserRepository
{
    public void Save(User user)
    {
        // IUserNotificationを実装した通知Objで、メンバにUserIdとUserNameを持つ
        var notifyObj = new UserDataModelBuilder();
        // Userクラス内のメソッドで、引数のObjにUserIdとUserNameを渡す。
        // 中で完結するのでgetterで外から触らずデメテルの法則キープ！
        user.Notify(notifyObj); 
        // 渡されたUserIdとUserNameを元に、Objが別のデータモデルクラスを生成。
        var userDataModel = notifyObj.Build();
        
        // このデータモデルクラスを使った別処理...
    }
}