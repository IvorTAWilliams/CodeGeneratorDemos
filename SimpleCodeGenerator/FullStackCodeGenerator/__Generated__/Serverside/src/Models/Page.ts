import { BaseEntity } from "./BaseEntity";

export class Page extends BaseEntity {
	BookId?: string;
	Contents?: string;
	PageNumber?: string;
}

