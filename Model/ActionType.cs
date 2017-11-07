namespace Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// ��������� �������� ������
    /// </summary>
    public enum ActionType
    {
        /// <summary>
        /// ������ �� ������
        /// </summary>
        None,
        /// <summary>
        /// ����� ��������� (� �����������)
        /// </summary>
        ClearAndSelect,
        /// <summary>
        /// �������� � ��������� (� �����������)
        /// </summary>
        AddToSelection,
        /// <summary>
        /// ����� ��������� (� �����������)
        /// </summary>
        Deselect,
        /// <summary>
        /// ���������� ��� ��������� �������������� � ������
        /// </summary>
        Assign,
        /// <summary>
        /// ������ ��� ��������� �������������� � ������
        /// </summary>
        Dismiss,
        /// <summary>
        /// �������������� ������
        /// </summary>
        Disband,
        /// <summary>
        /// ������ ���������� ������ ������������
        /// </summary>
        Move,
        /// <summary>
        /// ��������������
        /// </summary>
        Rotate,
        /// <summary>
        /// ��������� ������������ �� ������
        /// </summary>
        SetupVehicleProduction
    }
}