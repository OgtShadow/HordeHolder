import { ChangeDetectionStrategy, Component } from '@angular/core';

@Component({
  selector: 'app-connection-tester.component',
  imports: [],
  templateUrl: './connectionTester.component.html',
  styleUrl: './connectionTester.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ConnectionTesterComponent { }
