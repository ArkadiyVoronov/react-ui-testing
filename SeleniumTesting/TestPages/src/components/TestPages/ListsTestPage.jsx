import React from 'react';
import Button from 'retail-ui/components/Button';
import Input from 'retail-ui/components/Input';
import styled from 'styled-components';
import { CaseSuite, Case } from '../Case';

const Table = styled.table`
`;

const Row = styled.tr`
`;

const Cell = styled.td`
    border: 1px solid #666;
    padding: 5px;
    font-weight: ${props => props.bold ? '600' : '300'};
`;

export default class InputTextPage extends React.Component {
    state = {
        input1: '',
        input2: '',
        input3: '',
    };

    render(): React.Element<*> {
        return (
            <CaseSuite title='Списки'>
                <Case title='Hardcoded-список инпутов без tid-ов'>
                    <Case.Body data-tid='InputWithoutTidList'>
                        <Input 
                            value={this.state.input1} 
                            onChange={(e, value) => this.setState({ input1: value })}
                        />
                        <Input 
                            value={this.state.input2} 
                            onChange={(e, value) => this.setState({ input2: value })}
                        />
                        <Input 
                            value={this.state.input3} 
                            onChange={(e, value) => this.setState({ input3: value })}
                        />
                    </Case.Body>
                </Case>
                <Case title='Список составных read-only элементов '>
                    <Case.Body data-tid='CompositeReadonlyElementList'>
                        <div data-tid='Item'>
                            <div data-tid='Value1'>Value 11</div>
                            <div data-tid='Value2'>Value 12</div>
                        </div>
                        <div data-tid='Item'>
                            <div data-tid='Value1'>Value 21</div>
                            <div data-tid='Value2'>Value 22</div>
                        </div>
                        <div data-tid='Item'>
                            <div data-tid='Value1'>Value 31</div>
                            <div data-tid='Value2'>Value 32</div>
                        </div>
                    </Case.Body>
                </Case>
           </CaseSuite>
        );
    }
}