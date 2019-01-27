import { Injectable } from '@angular/core';

import { CanDeactivate, Router } from '@angular/router';
import { MemberEditComponent } from '../members/member-edit/member-edit.component';
import { AlertifyService } from '../_services/alertify.service';

@Injectable()
export class PreventUnSavedChanges implements CanDeactivate<MemberEditComponent> {

  constructor(private alertify: AlertifyService, private router: Router) {}

  canDeactivate(component: MemberEditComponent) {
    if (component.editForm.dirty) {
      return confirm('Are you sure you want to continue? Any unsaved changes will be lost!');
// const router = this.router;
//        this.alertify.confirm('Are you sure you want to continue? Any unsaved changes will be lost!',
//       function() {
//         // tslint:disable-next-line:no-debugger
//         debugger;
//         router.navigate(['/home']);

//       }
//       )

//       return true;
    } else {
  return true;
}

  }
}
