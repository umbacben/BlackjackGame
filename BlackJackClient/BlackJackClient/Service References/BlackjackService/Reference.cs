﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlackJackClient.BlackjackService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Game", Namespace="http://schemas.datacontract.org/2004/07/BlackjackService")]
    [System.SerializableAttribute()]
    public partial class Game : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BlackJackClient.BlackjackService.Deck GameDeckField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GameIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BlackJackClient.BlackjackService.Player Player1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BlackJackClient.BlackjackService.Player Player2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PotField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool inRoundField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BlackJackClient.BlackjackService.Deck GameDeck {
            get {
                return this.GameDeckField;
            }
            set {
                if ((object.ReferenceEquals(this.GameDeckField, value) != true)) {
                    this.GameDeckField = value;
                    this.RaisePropertyChanged("GameDeck");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GameId {
            get {
                return this.GameIdField;
            }
            set {
                if ((this.GameIdField.Equals(value) != true)) {
                    this.GameIdField = value;
                    this.RaisePropertyChanged("GameId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BlackJackClient.BlackjackService.Player Player1 {
            get {
                return this.Player1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Player1Field, value) != true)) {
                    this.Player1Field = value;
                    this.RaisePropertyChanged("Player1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BlackJackClient.BlackjackService.Player Player2 {
            get {
                return this.Player2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Player2Field, value) != true)) {
                    this.Player2Field = value;
                    this.RaisePropertyChanged("Player2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pot {
            get {
                return this.PotField;
            }
            set {
                if ((this.PotField.Equals(value) != true)) {
                    this.PotField = value;
                    this.RaisePropertyChanged("Pot");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool inRound {
            get {
                return this.inRoundField;
            }
            set {
                if ((this.inRoundField.Equals(value) != true)) {
                    this.inRoundField = value;
                    this.RaisePropertyChanged("inRound");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Deck", Namespace="http://schemas.datacontract.org/2004/07/BlackjackService")]
    [System.SerializableAttribute()]
    public partial class Deck : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BlackJackClient.BlackjackService.Card[] CardListField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BlackJackClient.BlackjackService.Card[] CardList {
            get {
                return this.CardListField;
            }
            set {
                if ((object.ReferenceEquals(this.CardListField, value) != true)) {
                    this.CardListField = value;
                    this.RaisePropertyChanged("CardList");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/BlackjackService")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HandValField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MoneyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BlackJackClient.BlackjackService.Card[] PlayHandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ReadyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool RoundDoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BlackJackClient.BlackjackService.User UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HandVal {
            get {
                return this.HandValField;
            }
            set {
                if ((this.HandValField.Equals(value) != true)) {
                    this.HandValField = value;
                    this.RaisePropertyChanged("HandVal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Money {
            get {
                return this.MoneyField;
            }
            set {
                if ((this.MoneyField.Equals(value) != true)) {
                    this.MoneyField = value;
                    this.RaisePropertyChanged("Money");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BlackJackClient.BlackjackService.Card[] PlayHand {
            get {
                return this.PlayHandField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayHandField, value) != true)) {
                    this.PlayHandField = value;
                    this.RaisePropertyChanged("PlayHand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Ready {
            get {
                return this.ReadyField;
            }
            set {
                if ((this.ReadyField.Equals(value) != true)) {
                    this.ReadyField = value;
                    this.RaisePropertyChanged("Ready");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool RoundDone {
            get {
                return this.RoundDoneField;
            }
            set {
                if ((this.RoundDoneField.Equals(value) != true)) {
                    this.RoundDoneField = value;
                    this.RaisePropertyChanged("RoundDone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BlackJackClient.BlackjackService.User UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Card", Namespace="http://schemas.datacontract.org/2004/07/BlackjackService")]
    [System.SerializableAttribute()]
    public partial class Card : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PicLocField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PicLoc {
            get {
                return this.PicLocField;
            }
            set {
                if ((object.ReferenceEquals(this.PicLocField, value) != true)) {
                    this.PicLocField = value;
                    this.RaisePropertyChanged("PicLoc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/BlackjackService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="BlackjackService", ConfigurationName="BlackjackService.IBlackjackGame", CallbackContract=typeof(BlackJackClient.BlackjackService.IBlackjackGameCallback))]
    public interface IBlackjackGame {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/Hit")]
        void Hit(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/Hit")]
        System.Threading.Tasks.Task HitAsync(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/Stay")]
        void Stay(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/Stay")]
        System.Threading.Tasks.Task StayAsync(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/IncreasePot")]
        void IncreasePot(BlackJackClient.BlackjackService.Game game, int mon);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/IncreasePot")]
        System.Threading.Tasks.Task IncreasePotAsync(BlackJackClient.BlackjackService.Game game, int mon);
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IBlackjackGame/GetWinner", ReplyAction="BlackjackService/IBlackjackGame/GetWinnerResponse")]
        BlackJackClient.BlackjackService.Player GetWinner(BlackJackClient.BlackjackService.Game game);
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IBlackjackGame/GetWinner", ReplyAction="BlackjackService/IBlackjackGame/GetWinnerResponse")]
        System.Threading.Tasks.Task<BlackJackClient.BlackjackService.Player> GetWinnerAsync(BlackJackClient.BlackjackService.Game game);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/LeaveGame")]
        void LeaveGame(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player leave);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/LeaveGame")]
        System.Threading.Tasks.Task LeaveGameAsync(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player leave);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/ReadyPlayer")]
        void ReadyPlayer(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/ReadyPlayer")]
        System.Threading.Tasks.Task ReadyPlayerAsync(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/SubscribeGame")]
        void SubscribeGame();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/SubscribeGame")]
        System.Threading.Tasks.Task SubscribeGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/UnsubscribeGame")]
        void UnsubscribeGame();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/UnsubscribeGame")]
        System.Threading.Tasks.Task UnsubscribeGameAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBlackjackGameCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IBlackjackGame/UpdateGame")]
        void UpdateGame(BlackJackClient.BlackjackService.Game game);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBlackjackGameChannel : BlackJackClient.BlackjackService.IBlackjackGame, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BlackjackGameClient : System.ServiceModel.DuplexClientBase<BlackJackClient.BlackjackService.IBlackjackGame>, BlackJackClient.BlackjackService.IBlackjackGame {
        
        public BlackjackGameClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public BlackjackGameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public BlackjackGameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public BlackjackGameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public BlackjackGameClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Hit(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player player) {
            base.Channel.Hit(game, player);
        }
        
        public System.Threading.Tasks.Task HitAsync(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player player) {
            return base.Channel.HitAsync(game, player);
        }
        
        public void Stay(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player player) {
            base.Channel.Stay(game, player);
        }
        
        public System.Threading.Tasks.Task StayAsync(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player player) {
            return base.Channel.StayAsync(game, player);
        }
        
        public void IncreasePot(BlackJackClient.BlackjackService.Game game, int mon) {
            base.Channel.IncreasePot(game, mon);
        }
        
        public System.Threading.Tasks.Task IncreasePotAsync(BlackJackClient.BlackjackService.Game game, int mon) {
            return base.Channel.IncreasePotAsync(game, mon);
        }
        
        public BlackJackClient.BlackjackService.Player GetWinner(BlackJackClient.BlackjackService.Game game) {
            return base.Channel.GetWinner(game);
        }
        
        public System.Threading.Tasks.Task<BlackJackClient.BlackjackService.Player> GetWinnerAsync(BlackJackClient.BlackjackService.Game game) {
            return base.Channel.GetWinnerAsync(game);
        }
        
        public void LeaveGame(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player leave) {
            base.Channel.LeaveGame(game, leave);
        }
        
        public System.Threading.Tasks.Task LeaveGameAsync(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player leave) {
            return base.Channel.LeaveGameAsync(game, leave);
        }
        
        public void ReadyPlayer(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player player) {
            base.Channel.ReadyPlayer(game, player);
        }
        
        public System.Threading.Tasks.Task ReadyPlayerAsync(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.Player player) {
            return base.Channel.ReadyPlayerAsync(game, player);
        }
        
        public void SubscribeGame() {
            base.Channel.SubscribeGame();
        }
        
        public System.Threading.Tasks.Task SubscribeGameAsync() {
            return base.Channel.SubscribeGameAsync();
        }
        
        public void UnsubscribeGame() {
            base.Channel.UnsubscribeGame();
        }
        
        public System.Threading.Tasks.Task UnsubscribeGameAsync() {
            return base.Channel.UnsubscribeGameAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="BlackjackService", ConfigurationName="BlackjackService.IChat", CallbackContract=typeof(BlackJackClient.BlackjackService.IChatCallback))]
    public interface IChat {
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IChat/SubscribeChat", ReplyAction="BlackjackService/IChat/SubscribeChatResponse")]
        void SubscribeChat();
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IChat/SubscribeChat", ReplyAction="BlackjackService/IChat/SubscribeChatResponse")]
        System.Threading.Tasks.Task SubscribeChatAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IChat/UnsubscribeChat", ReplyAction="BlackjackService/IChat/UnsubscribeChatResponse")]
        void UnsubscribeChat();
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IChat/UnsubscribeChat", ReplyAction="BlackjackService/IChat/UnsubscribeChatResponse")]
        System.Threading.Tasks.Task UnsubscribeChatAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IChat/AddMessage")]
        void AddMessage(int id, string playerName, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IChat/AddMessage")]
        System.Threading.Tasks.Task AddMessageAsync(int id, string playerName, string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IChat/onMessageAdded", ReplyAction="BlackjackService/IChat/onMessageAddedResponse")]
        void onMessageAdded(int gameId, System.DateTime dt, string playerName, string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatChannel : BlackJackClient.BlackjackService.IChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatClient : System.ServiceModel.DuplexClientBase<BlackJackClient.BlackjackService.IChat>, BlackJackClient.BlackjackService.IChat {
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void SubscribeChat() {
            base.Channel.SubscribeChat();
        }
        
        public System.Threading.Tasks.Task SubscribeChatAsync() {
            return base.Channel.SubscribeChatAsync();
        }
        
        public void UnsubscribeChat() {
            base.Channel.UnsubscribeChat();
        }
        
        public System.Threading.Tasks.Task UnsubscribeChatAsync() {
            return base.Channel.UnsubscribeChatAsync();
        }
        
        public void AddMessage(int id, string playerName, string message) {
            base.Channel.AddMessage(id, playerName, message);
        }
        
        public System.Threading.Tasks.Task AddMessageAsync(int id, string playerName, string message) {
            return base.Channel.AddMessageAsync(id, playerName, message);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="BlackjackService", ConfigurationName="BlackjackService.IPortal", CallbackContract=typeof(BlackJackClient.BlackjackService.IPortalCallback))]
    public interface IPortal {
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/Login", ReplyAction="BlackjackService/IPortal/LoginResponse")]
        BlackJackClient.BlackjackService.User Login(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/Login", ReplyAction="BlackjackService/IPortal/LoginResponse")]
        System.Threading.Tasks.Task<BlackJackClient.BlackjackService.User> LoginAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/Register", ReplyAction="BlackjackService/IPortal/RegisterResponse")]
        BlackJackClient.BlackjackService.User Register(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/Register", ReplyAction="BlackjackService/IPortal/RegisterResponse")]
        System.Threading.Tasks.Task<BlackJackClient.BlackjackService.User> RegisterAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/Logout", ReplyAction="BlackjackService/IPortal/LogoutResponse")]
        void Logout(BlackJackClient.BlackjackService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/Logout", ReplyAction="BlackjackService/IPortal/LogoutResponse")]
        System.Threading.Tasks.Task LogoutAsync(BlackJackClient.BlackjackService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/JoinGame", ReplyAction="BlackjackService/IPortal/JoinGameResponse")]
        bool JoinGame(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/JoinGame", ReplyAction="BlackjackService/IPortal/JoinGameResponse")]
        System.Threading.Tasks.Task<bool> JoinGameAsync(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/CreateGame", ReplyAction="BlackjackService/IPortal/CreateGameResponse")]
        BlackJackClient.BlackjackService.Game CreateGame(BlackJackClient.BlackjackService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/CreateGame", ReplyAction="BlackjackService/IPortal/CreateGameResponse")]
        System.Threading.Tasks.Task<BlackJackClient.BlackjackService.Game> CreateGameAsync(BlackJackClient.BlackjackService.User user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IPortal/GetGameList")]
        void GetGameList();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="BlackjackService/IPortal/GetGameList")]
        System.Threading.Tasks.Task GetGameListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/SubscribePortal", ReplyAction="BlackjackService/IPortal/SubscribePortalResponse")]
        void SubscribePortal();
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/SubscribePortal", ReplyAction="BlackjackService/IPortal/SubscribePortalResponse")]
        System.Threading.Tasks.Task SubscribePortalAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/UnSubscribePortal", ReplyAction="BlackjackService/IPortal/UnSubscribePortalResponse")]
        void UnSubscribePortal();
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/UnSubscribePortal", ReplyAction="BlackjackService/IPortal/UnSubscribePortalResponse")]
        System.Threading.Tasks.Task UnSubscribePortalAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPortalCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="BlackjackService/IPortal/UpdateGameList", ReplyAction="BlackjackService/IPortal/UpdateGameListResponse")]
        void UpdateGameList(BlackJackClient.BlackjackService.Game[] gameList);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPortalChannel : BlackJackClient.BlackjackService.IPortal, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PortalClient : System.ServiceModel.DuplexClientBase<BlackJackClient.BlackjackService.IPortal>, BlackJackClient.BlackjackService.IPortal {
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public BlackJackClient.BlackjackService.User Login(string user) {
            return base.Channel.Login(user);
        }
        
        public System.Threading.Tasks.Task<BlackJackClient.BlackjackService.User> LoginAsync(string user) {
            return base.Channel.LoginAsync(user);
        }
        
        public BlackJackClient.BlackjackService.User Register(string user) {
            return base.Channel.Register(user);
        }
        
        public System.Threading.Tasks.Task<BlackJackClient.BlackjackService.User> RegisterAsync(string user) {
            return base.Channel.RegisterAsync(user);
        }
        
        public void Logout(BlackJackClient.BlackjackService.User user) {
            base.Channel.Logout(user);
        }
        
        public System.Threading.Tasks.Task LogoutAsync(BlackJackClient.BlackjackService.User user) {
            return base.Channel.LogoutAsync(user);
        }
        
        public bool JoinGame(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.User user) {
            return base.Channel.JoinGame(game, user);
        }
        
        public System.Threading.Tasks.Task<bool> JoinGameAsync(BlackJackClient.BlackjackService.Game game, BlackJackClient.BlackjackService.User user) {
            return base.Channel.JoinGameAsync(game, user);
        }
        
        public BlackJackClient.BlackjackService.Game CreateGame(BlackJackClient.BlackjackService.User user) {
            return base.Channel.CreateGame(user);
        }
        
        public System.Threading.Tasks.Task<BlackJackClient.BlackjackService.Game> CreateGameAsync(BlackJackClient.BlackjackService.User user) {
            return base.Channel.CreateGameAsync(user);
        }
        
        public void GetGameList() {
            base.Channel.GetGameList();
        }
        
        public System.Threading.Tasks.Task GetGameListAsync() {
            return base.Channel.GetGameListAsync();
        }
        
        public void SubscribePortal() {
            base.Channel.SubscribePortal();
        }
        
        public System.Threading.Tasks.Task SubscribePortalAsync() {
            return base.Channel.SubscribePortalAsync();
        }
        
        public void UnSubscribePortal() {
            base.Channel.UnSubscribePortal();
        }
        
        public System.Threading.Tasks.Task UnSubscribePortalAsync() {
            return base.Channel.UnSubscribePortalAsync();
        }
    }
}
