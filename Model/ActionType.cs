namespace Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Возможные действия игрока
    /// </summary>
    public enum ActionType
    {
        /// <summary>
        /// Ничего не делать
        /// </summary>
        None,
        /// <summary>
        /// Новое выделение (с параметрами)
        /// </summary>
        ClearAndSelect,
        /// <summary>
        /// Добавить к выделению (с параметрами)
        /// </summary>
        AddToSelection,
        /// <summary>
        /// Снять выделение (с параметрами)
        /// </summary>
        Deselect,
        /// <summary>
        /// Установить для выделения принадлежность к группе
        /// </summary>
        Assign,
        /// <summary>
        /// Убрать для выделения принадлежность к группе
        /// </summary>
        Dismiss,
        /// <summary>
        /// Расформировать группу
        /// </summary>
        Disband,
        /// <summary>
        /// Приказ выделенным юнитам перемещаться
        /// </summary>
        Move,
        /// <summary>
        /// Поворачиваться
        /// </summary>
        Rotate,
        /// <summary>
        /// Настроить производство на заводе
        /// </summary>
        SetupVehicleProduction
    }
}