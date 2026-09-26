import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { UserRow } from "./UserRow";

export interface UserColumns {
    UserId: Column<UserRow>;
    Username: Column<UserRow>;
    DisplayName: Column<UserRow>;
    Email: Column<UserRow>;
    Source: Column<UserRow>;
    Inn: Column<UserRow>;
    PhoneNumber: Column<UserRow>;
    Roles: Column<UserRow>;
    lastName: Column<UserRow>;
}

export class UserColumns extends ColumnsBase<UserRow> {
    static readonly columnsKey = 'Administration.User';
    static readonly Fields = fieldsProxy<UserColumns>();
}