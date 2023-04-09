using System.ComponentModel;

namespace UserApi.Enums
{
    public enum TaskStatus {
        [Description("To do")]
        ToDo = 1,
        [Description("In Progress")]
        InProgress = 2,
        [Description("Finished")]
        Finished = 3
    }
}
