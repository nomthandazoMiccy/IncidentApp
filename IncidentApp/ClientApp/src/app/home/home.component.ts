import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { RegConfirmDialogComponent } from '../reg-confirm-dialog/reg-confirm-dialog.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  constructor(public dialog: MatDialog) { }
  ngOnInit(): void {
  }
  openDialog() {
    const dialogRef = this.dialog.open(RegConfirmDialogComponent, {
      width: '350px',
    });
  }
}
